using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Lyrics:IVKEntity<Lyrics> {
        public VKApi Context { get; set; }

        public string Text { get; set; }

        public int LyricsId { get; set; }
    }
}
