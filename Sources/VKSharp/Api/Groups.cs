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
        public async Task<User[]> GroupsGetBannedAsync( uint groupId, uint offset = 0, ushort count = 100) {
            var req = new VKRequest<User> {
                MethodName = "groups.getBanned",
                Parameters = new Dictionary<string, string> {
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() },
                    { "group_id", groupId.ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }

        public async Task<MemberShip[]> GroupsIsMemberAsync( string groupId, bool extended = false, params uint[] userIds) {
                var req = new VKRequest<MemberShip> {
                MethodName = "groups.isMember",
                Parameters = new Dictionary<string, string> {
                    { "user_ids", userIds.ToNCStringA() },
                    { "group_id", groupId },
                    {"extended", (extended?1:0).ToNCString()}
                }
            };
            return (await _executor.ExecAsync(req)).Data;
        }
        public async Task<StructEntity<bool>> GroupsJoinAsync(uint groupId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "groups.join",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                }
            };

            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> GroupsLeaveAsync(uint groupId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "groups.leave",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                }
            };

            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> GroupsUnbanUserAsync(uint groupId, uint userId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "groups.unbanUser",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "user_id", userId.ToNCString() },
                }
            };

            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}
