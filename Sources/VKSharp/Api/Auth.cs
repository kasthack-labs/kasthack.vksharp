using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> AuthCheckPhoneAsync( string phone, string clientSecret, int? clientId = null) {
                var req = new VKRequest<StructEntity<bool>> {
                    MethodName = "auth.checkPhone",
                    Parameters = new Dictionary<string, string> {
                        { "phone", phone },
                        { "client_secret", clientSecret },
                        { "client_id", MiscTools.NullableString( clientId ) }
                    },
                    Token = this.IsLogged ? this.CurrenToken : null
                };
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}
