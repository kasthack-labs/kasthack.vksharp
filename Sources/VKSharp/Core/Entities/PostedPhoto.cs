using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostedPhoto : OwnedEntity<PostedPhoto> {
        public string Photo130 { get; set; }
        public string Photo640 { get; set; }
    }
}
