using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Photo : OwnedEntity {
        public string AccessKey { get; set; }
        public int? PostId { get; set; }
        public int? UserId { get; set; }
        public int AlbumId { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public int Date { get; set; }
        public bool? CanComment { get; set; }
        public PhotoLikes Likes { get; set; }
        public Counter Tags { get; set; }
        public Counter Comments { get; set; }
        public PhotoSize[] Sizes { get; set; }
        public static implicit operator Attachment( Photo photo ) => new Attachment { Photo = photo, Type = AttachmentType.Photo };
    }
}
