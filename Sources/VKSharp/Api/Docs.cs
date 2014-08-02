using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<int>> DocsAddAsync(int ownerId, uint docId, string accessKey="") {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "docs.add",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "doc_id", docId.ToNCString() },
                        { "access_key", accessKey }
                    }
            };
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task DocsDeleteAsync(uint docsId, int ownerId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "docs.delete",
                Parameters = new Dictionary<string, string> { { "doc_id", docsId.ToNCString() },
                { "owner_id", ownerId.ToNCString() } }
            };
            req.Token = CurrenToken;
            await _executor.ExecAsync( req );
        }
        public async Task<SimpleEntity<string>> DocsGetUploadServerAsync(uint? groupId = null) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "docs.getUploadServer",
                Parameters = new Dictionary<string, string> {
                    {"group_id", MiscTools.NullableString( groupId )}
                }
            };
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<SimpleEntity<string>> DocsGetWallUploadServerAsync(uint? groupId = null)
        {
            var req = new VKRequest<SimpleEntity<string>>
            {
                MethodName = "docs.getWallUploadServer",
                Parameters = new Dictionary<string, string> {
                    {"group_id", MiscTools.NullableString( groupId )}
                }
            };
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<EntityList<Document>> DocsGetAsync(int? count=null, int? offset=null, int? ownerId = null) {
            var req = new VKRequest<EntityList<Document>>
            {
                MethodName = "docs.get",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", MiscTools.NullableString( ownerId ) },
                        { "count", MiscTools.NullableString( count ) },
                        { "offset", MiscTools.NullableString( offset ) },
                    }
            };
            if ( IsLogged ) req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<Document[]> DocsGetByIdAsync(params Tuple<int,int>[] docs)
        {
            var req = new VKRequest<Document> {
                MethodName = "docs.getById",
                Parameters = new Dictionary<string, string> {
                        {"docs",String.Join( ",", docs.Select( a=>a.Item1+"_"+a.Item2 ) )}
                    }
            };
            if (IsLogged) req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }
        public async Task<Document[]> DocsSaveAsync( string file, string title, params string[] tags ) {
            var req = new VKRequest<Document> {
                MethodName = "docs.save",
                Parameters = new Dictionary<string, string> {
                        {"file",file},
                        {"title",title},
                        {"tags",String.Join( ",", tags )},
                    }
            };
            if (IsLogged) req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }
    }
}