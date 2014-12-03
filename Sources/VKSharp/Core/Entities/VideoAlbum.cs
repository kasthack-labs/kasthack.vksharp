using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class VideoAlbum : OwnedEntity<VideoAlbum> {
        public string Title { get; set; }
        public long? Count { get; set; }
        public string Photo160 { get; set; }
        public string Photo320 { get; set; }
    }
}
