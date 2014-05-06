using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Helpers.PrimitiveEntities;

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
            return Helper.SyncTask( this.FriendsGetAsync( userId, order, listId, offset, count, fields, nameCase ) );
        }

        public User[] FriendsGetByPhones( IEnumerable<ulong> phones, UserFields fields = UserFields.None ) {
            return Helper.SyncTask( this.FriendsGetByPhonesAsync( phones, fields ) );
        }

        public User[] FriendsGetSuggestions(
            FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.FriendsGetSuggestionsAsync( filters, offset, count, fields, nameCase ) );
        }

        public StructEntity<int>[] FriendsGetAppUsers() { return Helper.SyncTask( this.FriendsGetAppUsersAsync() ); }

        public StructEntity<bool> FriendsDeleteList( uint listId ) { return Helper.SyncTask( this.FriendsDeleteListAsync( listId ) ); }
        public StructEntity<int> FriendsAdd( uint userId, string text ) { return Helper.SyncTask( this.FriendsAddAsync( userId, text ) ); }
        public StructEntity<int> FriendsDelete( uint userId ) { return Helper.SyncTask( this.FriendsDeleteAsync( userId ) ); }

        public StructEntity<int>[] FriendsGetRecent( int? count = null ) { return Helper.SyncTask( this.FriendsGetRecentAsync( count ) ); }

        public StructEntity<int>[] FriendsGetMutual(
            uint targetId,
            uint? sourceId = null,
            bool randomOrder = false,
            int? count = null,
            int? offset = null ) {
            return Helper.SyncTask( this.FriendsGetMutualAsync( targetId, sourceId, randomOrder, count, offset ) );
        }
    }
}