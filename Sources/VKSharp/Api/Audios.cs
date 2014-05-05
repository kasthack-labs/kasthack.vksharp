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
        public async Task<EntityList<Audio>> AudiosGetAsync(
           int? ownerId=null,
           int? albumId=null,
           IEnumerable<ulong> audioIds=null,
           bool needUser=false,
           int offset=0,
           int? count=null) {
               var req = new VKRequest<EntityList<Audio>> {
                MethodName = "audio.get",
                Parameters = new Dictionary<string, string> {
                    { "offset", offset.ToNCString() },
                    { "count", MiscTools.NullableString( count ) },
                    { "need_user", (needUser?1:0).ToNCString() },
                    { "owner_id", MiscTools.NullableString(ownerId) },
                    { "album_id", MiscTools.NullableString(albumId) },
                    { "audio_ids", String.Join(",", audioIds?? new ulong[]{} )}
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> AudiosReorderAsync(
           ulong audioId,
           int? ownerId = null,
           ulong? after = null,
           ulong? before = null) {
               var req = new VKRequest<StructEntity<bool>> {
                MethodName = "audio.reorder",
                Parameters = new Dictionary<string, string> {
                    { "audio_id", audioId.ToNCString() },
                    { "owner_id", MiscTools.NullableString(ownerId) },
                    { "after", MiscTools.NullableString(after) },
                    { "before", MiscTools.NullableString(before) },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}
