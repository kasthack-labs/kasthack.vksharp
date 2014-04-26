using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public EntityList<Audio> AudiosGet(
           int? ownerId=null,
           int? albumId=null,
           IEnumerable<ulong> audioIds=null,
           bool needUser=false,
           int offset=0,
           int? count=null) {
            return Helper.SyncTask(
                this.AudiosGetAsync(
                    ownerId,
                    albumId,
                    audioIds,
                    needUser,
                    offset,
                    count ) );
        }
    }
}
