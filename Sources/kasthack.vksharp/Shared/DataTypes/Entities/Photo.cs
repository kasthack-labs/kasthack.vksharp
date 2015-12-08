using System;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
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
        public DateTimeOffset Date { get; set; }
        public bool? CanComment { get; set; }
        public PhotoLikes Likes { get; set; }
        //public Counter Tags { get; set; }
        public Counter Comments { get; set; }
        public PhotoSize[] Sizes { get; set; }

        public static implicit operator Attachment( Photo photo ) => new Attachment { Photo = photo, Type = ContentType.Photo };

        public static implicit operator ObjectContentId(Photo photo) => new ObjectContentId( ContentType.Photo, photo.Id, photo.OwnerId, photo.AccessKey );

        public static implicit operator ContentId( Photo photo ) => (ObjectContentId) photo;

    }
}
