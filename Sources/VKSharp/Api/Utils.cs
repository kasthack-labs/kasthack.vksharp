using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<uint>> UtilsGetServerTimeAsync() {
            var req = new VKRequest<StructEntity<uint>> {
                MethodName = "utils.getServerTime",
                Parameters = new Dictionary<string, string>()
            };
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<LinkCheckResult> UtilsCheckLink( string url ) {
            var req = new VKRequest<LinkCheckResult> {
                MethodName = "utils.checkLink",
                Parameters = new Dictionary<string, string> {
                    {"url", url}
                }
            };
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}
