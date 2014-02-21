using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public User[] UsersGet( UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params uint[] ids ) {
            return Helper.SyncTask( this.UsersGetAsync( fields, nameCase, ids ) );
        }
        public EntityList<User> UsersGetFollowers( uint userId,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.UsersGetFollowersAsync( userId, offset, count, fields, nameCase ) );
        }

        public StructEntity<bool> UserIsAppUser( uint? userId ) {
                return Helper.SyncTask( this.UserIsAppUserAsync( userId ) );
        }
    }
}
