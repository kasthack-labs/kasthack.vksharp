using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class PostedPhoto:IVKEntity<PostedPhoto> {
        public uint ID { get; set; }
        public int OwnerID { get; set; }
        public string Photo130 { get; set; }
        public string Photo640 { get; set; }
        public IVKEntityParser<PostedPhoto> GetParser() {
            return PostedPhotoParser.Instanse;
        }
    }
}
