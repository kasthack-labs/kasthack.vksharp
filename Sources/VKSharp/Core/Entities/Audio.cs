using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Audio : OwnedEntity<Audio> {
        public AudioGenre Genre { get; set; }
        public int AlbumID { get; set; }
        public int LyricsID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public uint Duration { get; set; }

    }
}
