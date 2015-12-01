using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class VideoAlbum : OwnedEntity {
        public string Title { get; set; }
        public long? Count { get; set; }
        public string Photo160 { get; set; }
        public string Photo320 { get; set; }
    }
}
