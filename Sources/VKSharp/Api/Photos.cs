using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<int>> PhotosGetAlbumCountAsync( uint? userId, uint? groupId ) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "photos.getAlbumsCount",
                Parameters =
                    new Dictionary<string, string> {
                        { "user_id", MiscTools.NullableString( userId ) },
                        { "group_id", MiscTools.NullableString( groupId ) }
                    }
            };
            if ( this.IsLogged )
                req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<SimpleEntity<string>> PhotosGetProfileUploadServerAsync() {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "photos.getProfileUploadServer",
                Parameters = new Dictionary<string, string>()
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<SimpleEntity<string>> PhotosGetUploadServerAsync( int album_id, uint? group_id ) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "photos.getUploadServer",
                Parameters =
                    new Dictionary<string, string> {
                        { "album_id", album_id.ToNCString() },
                        { "group_id", MiscTools.NullableString( group_id ) }
                    }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
    }
}