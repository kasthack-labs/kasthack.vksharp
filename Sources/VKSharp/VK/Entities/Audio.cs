using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Audio:IVKEntity<Audio> {
        public ulong ID { get; set; }
        public int OwnerID { get; set; }
        public string Title { get; set; }
        public uint Duration { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
        public int LyricsID { get; set; }
        public int AlbumID { get; set; }
        public AudioGenre Genre { get; set; }
        public IVKEntityParser<Audio> GetParser() {
            return AudioParser.Instanse;
        }
    }
}
