using EpicMorg.Net;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public User[] GroupsGetBanned(uint groupId, uint offset = 0, ushort count = 100) {
            return Helper.SyncTask(this.GroupsGetBannedAsync(groupId, offset, count));
        }
    }
}
