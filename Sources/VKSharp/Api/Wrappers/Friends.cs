using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;

namespace VKSharp {
    public partial class VKApi {


        public User[] FriendsGet(
            uint userID,
            UserSortOrder order = UserSortOrder.ByID,
            uint? listID = null,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask(
                this.FriendsGetAsync(
                    userID,
                    order,
                    listID,
                    offset,
                    count,
                    fields,
                    nameCase
                )
            );
        }

        public User[] FriendsGetByPhones(
            IEnumerable<ulong> phones,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name) {
            return Helper.SyncTask(this.FriendsGetByPhonesAsync(phones, fields));
        }

        public User[] FriendsGetSuggestions(
            FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
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