using EpicMorg.Net;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public User[] AccountGetBanned( uint offset = 0, ushort count = 100 ) {
            return Helper.SyncTask( this.AccountGetBannedAsync( offset, count ) );
        }
    }
}
