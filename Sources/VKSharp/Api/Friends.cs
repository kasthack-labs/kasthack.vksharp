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
        //FriendsDeleteAsync
        //TODO: Add mapping of return code to enum
        //FriendsDeleteAsync
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