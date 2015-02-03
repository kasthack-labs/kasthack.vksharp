using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {

    public class PhotoAlbum : OwnedEntity<PhotoAlbum> {
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
    }
}
