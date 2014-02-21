using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;

namespace VKSharp {
    public partial class VKApi {


        public User[] FriendsGet(
            uint userId,
            UserSortOrder order = UserSortOrder.ById,
            uint? listId = null,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask(
                this.FriendsGetAsync(
                    userId,
                    order,
                    listId,
                    offset,
                    count,
                    fields,
                    nameCase
                )
            );
        }

        public User[] FriendsGetByPhones(
            IEnumerable<ulong> phones,
            UserFields fields = UserFields.None ) {
            return Helper.SyncTask(this.FriendsGetByPhonesAsync(phones, fields));
        }

        public User[] FriendsGetSuggestions(
            FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom) {
                return Helper.SyncTask(
                    this.FriendsGetSuggestionsAsync(
                        filters,
                        offset,
                        count,
                        fields,
                        nameCase
                    )
                );
        }
    }
}