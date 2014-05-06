using System.Collections.Generic;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Helpers.PrimitiveEntities;

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

        public StructEntity<bool> AudiosReorder(
            ulong audioId,
            int? ownerId = null,
            ulong? after = null,
            ulong? before = null ) {
            return Helper.SyncTask(this.AudiosReorderAsync( audioId, ownerId, after, before ));
        }

        public Lyrics AudiosGetLyrics( int lyricsId ) {
            return Helper.SyncTask( this.AudiosGetLyricsAsync( lyricsId ) );
        }
    }
}
