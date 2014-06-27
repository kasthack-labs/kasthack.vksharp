using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task NewsfeedAddBanAsync(IEnumerable<uint> userIds, IEnumerable<int> groupIds) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "newsfeed.addBan",
                Parameters = new Dictionary<string, string> {
                    {"user_ids",userIds.ToNCStringA()},
                    {"group_ids",groupIds.ToNCStringA()}
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync( req );
        }
        public async Task NewsfeedDeleteBanAsync(IEnumerable<uint> userIds, IEnumerable<int> groupIds) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "newsfeed.deleteBan",
                Parameters = new Dictionary<string, string> {
                    {"user_ids",userIds.ToNCStringA()},
                    {"group_ids",groupIds.ToNCStringA()}
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            await this._executor.ExecAsync(req);
        }
    }
}
