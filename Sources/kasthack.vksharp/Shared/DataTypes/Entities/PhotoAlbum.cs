using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {

    public class PhotoAlbum : OwnedEntity {
        public int ThumbId { get; set; }
        public string ThumbSrc { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Created { get; set; }
        public int Updated { get; set; }
        public int Size { get; set; }
        public bool CanUpload { get; set; }
        public Privacy PrivacyView { get; set; }
        public Privacy PrivacyComment { get; set; }

        public static implicit operator ObjectContentId(PhotoAlbum album)=> new ObjectContentId( ContentType.Album, album.Id, album.OwnerId );

        public static implicit operator ContentId( PhotoAlbum album ) => (ObjectContentId) album;

    }
}
