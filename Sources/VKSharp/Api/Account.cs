using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp {
    public partial class VKApi {
        public async Task<User[]> AccountGetBannedAsync(
            uint offset = 0,
            ushort count = 20 ) {
            var req = new VKRequest<User> {
                MethodName = "account.getBanned",
                Parameters = new Dictionary<string, string> {
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            return ( await this._executor.ExecAsync( req ) ).Data;
        }
    }
}
