using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using VKSharp.Core.Entities;

namespace VKSharp.Helpers
{
    public class UploadHelper
    {
        private readonly VKApi _api;
        private readonly HttpClient _client;

        public UploadHelper( VKApi api ) {
            _api = api;
            _client = new HttpClient();
        }

        public async Task<IEnumerable<Photo>> UploadPhotos( long albumId, int? userId, params string[] files ) {
            var ret = new List<Photo>(files.Length);
            uint? gid = 0;
            if ( userId != null && userId < 0 ) gid = (uint?)-userId;
            foreach ( var fileg in files.Select( (path,index)=>new{path,index} ).GroupBy( a=>a.index/5 ) ) {
                FileStream[] streams = null;
                try {
                    var us = await _api.PhotosGetUploadServerAsync( albumId, gid == 0 ? null : gid );
                    var ul = fileg.Select( a => a.path ).ToArray();
                    streams = ul.Select( File.OpenRead ).ToArray();
                    using ( var content = new MultipartFormDataContent() ) {
                        for ( var index = 0; index < streams.Length; index++ )
                            content.Add( new StreamContent( streams[ index ] ), "file" + index, index + Path.GetExtension( ul[ index ] ) );
                        var upl = await _client.PostAsync( us.UploadUrl, content );
                        var respjson = await upl.Content.ReadAsStringAsync();
                        throw new NotImplementedException();
                        //Add response parsing here
                        //Also fix PhotosSaveAsync params 
                    }
                    var hash = "goes_here";
                    var photosList = "";
                    var server = "goes here";
                    ret.AddRange( await _api.PhotosSaveAsync( server, hash, photosList: photosList ) );
                }
                catch(Exception ex) {
                    throw;
                }
                finally {
                    foreach ( var stream in streams ) {
                        try {
                            stream.Close();
                        }
                        catch {}
                    }
                }
            }
            return ret;
        }
    }
}
