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
        public async Task<StructEntity<bool>> StatusSet( string text ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "status.set",
                Parameters = new Dictionary<string, string>() {
                    {
                        "text", text
                    }
                }
            };
            return ( await this.Executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
    }
}
