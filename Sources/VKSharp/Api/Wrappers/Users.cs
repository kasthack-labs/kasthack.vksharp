using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public User[] UsersGet( UserFields fields = UserFields.First_Name | UserFields.Last_Name, NameCase nameCase = NameCase.Nom, params uint[] ids ) {
            return Helper.SyncTask( this.UsersGetAsync( fields, nameCase, ids ) );
        }
        public EntityList<User> UsersGetFollowers( uint userID,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.UsersGetFollowersAsync( userID, offset, count, fields, nameCase ) );
        }

        public StructEntity<bool> UserIsAppUser( uint? userID ) {
                return Helper.SyncTask( this.UserIsAppUserAsync( userID ) );
        }
    }
}
