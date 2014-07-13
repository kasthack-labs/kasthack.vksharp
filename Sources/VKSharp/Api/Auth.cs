using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;
using VKSharp.Core.ResponseEntities;

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
                Token = IsLogged ? CurrenToken : null
            };
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<ConfirmResult> AuthConfirmAsync(
            uint clientId,
            string clientSecret,
            string phone,
            string code,
            string password = "",
            bool testMode = false,
            int? intro = null
        ){
            var req = new VKRequest<ConfirmResult> {
                MethodName = "auth.confirm",
                Parameters = new Dictionary<string, string> {
                    { "client_id", clientId.ToNCString() },
                    { "client_secret", clientSecret },
                    { "phone", phone },
                    { "code", code },
                    { "password", password },
                    { "test_mode", testMode?"1":"0" },
                    { "intro", MiscTools.NullableString(intro) }
                },
                Token = IsLogged ? CurrenToken : null
            };
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}
