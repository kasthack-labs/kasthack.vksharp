using VKSharp.Core.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostedPhoto : OwnedEntity<PostedPhoto> {
        public string Photo130 { get; set; }
        public string Photo640 { get; set; }
        public override IVKEntityParser<PostedPhoto> GetParser() {
            return PostedPhotoParser.Instanse;
        }
    }
}
