using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<SimpleEntity<string>> DocsGetUploadServerAsync(uint? groupId = null) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "docs.getUploadServer",
                Parameters = new Dictionary<string, string> {
                    {"group_id", MiscTools.NullableString( groupId )}
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> DocsGetWallUploadServerAsync(uint? groupId=null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "docs.getWallUploadServer",
                Parameters = new Dictionary<string, string> {
                    {"group_id", MiscTools.NullableString( groupId )}
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<int>> DocsAddAsync(int ownerId, uint docId, string accessKey) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "docs.add",
                Parameters =
                    new Dictionary<string, string> {
                        { "owner_id", ownerId.ToNCString() },
                        { "doc_id", docId.ToNCString() },
                        { "access_key", accessKey }
                    }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> DocsDeleteAsync(uint docsId, int ownerId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "docs.delete",
                Parameters = new Dictionary<string, string> { { "doc_id", docsId.ToNCString() }, { "owner_id", ownerId.ToNCString() } }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        
    }
}
