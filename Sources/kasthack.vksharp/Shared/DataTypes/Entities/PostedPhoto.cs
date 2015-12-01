using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class PostedPhoto : OwnedEntity {
        public string Photo130 { get; set; }
        public string Photo640 { get; set; }
        public static implicit operator ObjectContentId(PostedPhoto photo)=>new ObjectContentId( ContentType.PostedPhoto, photo.Id, photo.OwnerId );
    }
}
