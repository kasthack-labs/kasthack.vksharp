using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public
            //Audio[]
            EntityList<Audio>
            AudiosGet(
           int? ownerID=null,
           int? albumID=null,
           IEnumerable<ulong> audioIds=null,
           bool needUser=false,
           int offset=0,
           int? count=null) {
            return Helper.SyncTask(
                this.AudiosGetAsync(
                    ownerID,
                    albumID,
                    audioIds,
                    needUser,
                    offset,
                    count ) );
        }
    }
}
