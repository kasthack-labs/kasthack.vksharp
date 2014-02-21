using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Photo : OwnedEntity<Photo> {
        public int AlbumId { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public string Text { get; set; }
        public uint Date { get; set; }
    }
}
