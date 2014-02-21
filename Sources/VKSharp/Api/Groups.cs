using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp {
    public partial class VKApi {
        public async Task<User[]> GroupsGetBannedAsync(
            uint groupId,
            uint offset = 0,
            ushort count = 100) {
            var req = new VKRequest<User> {
                MethodName = "groups.getBanned",
                Parameters = new Dictionary<string, string> {
                    { "offset", offset.ToString(BuiltInData.Instance.NC) },
                    { "count", count.ToString(BuiltInData.Instance.NC) },
                    { "group_id", groupId.ToString(BuiltInData.Instance.NC) }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data;
        }
    }
}
