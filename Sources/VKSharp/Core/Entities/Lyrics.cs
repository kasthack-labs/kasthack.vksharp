using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Lyrics:IVKEntity<Lyrics> {
        

        public string Text { get; set; }

        public int LyricsId { get; set; }
    }
}
