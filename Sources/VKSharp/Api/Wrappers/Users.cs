using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;
using System;

namespace VKSharp {
    public partial class VKApi {
        public User[] UsersGet( IEnumerable<uint> ids, UserFields fields = UserFields.First_Name | UserFields.Last_Name, NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.UsersGetAsync( ids, fields, nameCase ) );
        }
        public EntityList<User> UsersGetFollowers( uint userID,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.UsersGetFollowersAsync( userID, offset, count, fields, nameCase ) );
        }

        public StructEntity<bool> UserIsAppUser( uint? userID ) {
//                Console.WriteLine(5.ToNCLString());
                return Helper.SyncTask( this.UserIsAppUserAsync( userID ) );
        }
    }
}
