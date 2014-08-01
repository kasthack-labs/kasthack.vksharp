using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task AccountBanUserAsync(uint userId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "account.banUser",
                Parameters = new Dictionary<string, string> {
                    { "user_id", userId.ToNCString() }
                }
            };
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task<User[]> AccountGetBannedAsync( uint offset = 0, ushort count = 20 ) {
            var req = new VKRequest<User> {
                MethodName = "account.getBanned",
                Parameters = new Dictionary<string, string> {
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() }
                }
            };
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task AccountSetInfoAsync(uint? intro) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "account.setInfo",
                Parameters = new Dictionary<string, string> {
                    { "intro", MiscTools.NullableString( intro ) }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task AccountSetOfflineAsync() {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "account.setOffline",
                Parameters = new Dictionary<string, string>()
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync( req );
        }
        public async Task AccountSetOnlineAsync(bool voip) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "account.setOnline",
                Parameters = new Dictionary<string, string> {
                    { "voip", (voip?1:0).ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task AccountUnbanUserAsync(uint userId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "account.unbanUser",
                Parameters = new Dictionary<string, string> {
                    { "user_id", userId.ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task AccountUnregisterDeviceAsync(string token) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "account.unregisterDevice",
                Parameters = new Dictionary<string, string> {
                    { "token", token }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
    }
}
