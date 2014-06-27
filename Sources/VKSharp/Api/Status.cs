using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> StatusSet( string text ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "status.set",
                Parameters = new Dictionary<string, string> { { "text", text } }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return ( await this.Executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
    }
}
