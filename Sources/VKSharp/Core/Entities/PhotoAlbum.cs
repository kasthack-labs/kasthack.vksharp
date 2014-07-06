using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {

    public class PhotoAlbum : OwnedEntity<PhotoAlbum> {
        //public Photo Thumb { get; set; }//equals null if album is attached to post|message
        public uint ThumbId { get; set; }
        public string ThumbSrc { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Created { get; set; }
        public uint Updated { get; set; }
        public uint Size { get; set; }
        public bool CanUpload { get; set; }
        public Privacy PrivacyView { get; set; }
        public Privacy PrivacyComment { get; set; }
    }
}
