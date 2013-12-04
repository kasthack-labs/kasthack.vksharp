using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {

    public class PhotoAlbumBase : OwnedEntity<PhotoAlbumBase> {
        public Photo Thumb { get; set; }//equals null if album is attached to post|message
        public string Title { get; set; }
        public string Description { get; set; }
        public uint CreatedDate { get; set; }
        public uint UpdatedDate { get; set; }
        public uint Size { get; set; }
    }
}
