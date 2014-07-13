using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        //TODO: Add mapping of return code to enum
        public async Task<StructEntity<int>> FriendsAddAsync(uint userId, string text) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "friends.add",
                Parameters = new Dictionary<string, string> { { "user_id", userId.ToNCString() }, { "text", text } }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }

        public async Task FriendsDeleteAllRequestsAsync() {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "friends.deleteAllRequests",
                Parameters = new Dictionary<string, string> {}
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }

        //TODO: Add mapping of return code to enum
        public async Task<StructEntity<int>> FriendsDeleteAsync(uint userId) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "friends.delete",
                Parameters = new Dictionary<string, string> {
                    { "user_id", userId.ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        
        public async Task FriendsDeleteListAsync(uint listId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "friends.deleteList",
                Parameters = new Dictionary<string, string> {
                    { "list_id", listId.ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }

        public async Task<StructEntity<int>[]> FriendsGetAppUsersAsync() {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "friends.getAppUsers",
                Parameters = new Dictionary<string, string>()
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data;
        }

        public async Task<User[]> FriendsGetAsync( uint userId, UserSortOrder order = UserSortOrder.ById,
            uint? listId = null, uint offset = 0, ushort count = 100, UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom) {
            var req = new VKRequest<User> {
                MethodName = "friends.get",
                Parameters =
                    new Dictionary<string, string> {
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
                        { "list_id", MiscTools.NullableString( listId ) },
                        { "order", order == UserSortOrder.ById ? "" : order.ToNClString() },
                        { "user_id", userId.ToNCString() },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },
                        { "name_case", nameCase.ToNClString() }
                    },
                Token = IsLogged ? CurrenToken : null
            };
            return (await _executor.ExecAsync(req)).Data;
        }

        public async Task<User[]> FriendsGetByPhonesAsync(IEnumerable<ulong> phones, UserFields fields = UserFields.None) {
            var req = new VKRequest<User> {
                MethodName = "friends.get",
                Parameters =
                    new Dictionary<string, string> {
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
                        { "phones", String.Join( ",", phones.Select( a => "+" + a ) ) }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }

        public async Task<StructEntity<int>[]> FriendsGetMutualAsync(
            uint targetId, uint? sourceId = null, bool randomOrder = false, int? count = null, int? offset = null) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "friends.getMutual",
                Parameters =
                    new Dictionary<string, string> {
                        { "target_uid", targetId.ToNCString() },
                        { "source_uid", MiscTools.NullableString( sourceId ) },
                        { "order", randomOrder ? "random" : "" },
                        { "count", MiscTools.NullableString( count ) },
                        { "offset", MiscTools.NullableString( offset ) }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }

        public async Task<StructEntity<int>[]> FriendsGetRecentAsync(int? count = null) {
            var req = new VKRequest<StructEntity<int>> {
                MethodName = "friends.getRecent",
                Parameters = new Dictionary<string, string> { { "count", MiscTools.NullableString(count) } }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }

        public async Task<User[]> FriendsGetSuggestionsAsync(
            FriendSuggestionFilters filters = FriendSuggestionFilters.Everything, uint offset = 0,
            ushort count = 100, UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom) {
            var req = new VKRequest<User> {
                MethodName = "friends.get",
                Parameters =
                    new Dictionary<string, string> {
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
                        { "filters", String.Join( ",", MiscTools.GetFilterFields( filters ) ) },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },
                        { "name_case", nameCase.ToNClString() }
                    }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data;
        }
    }
}