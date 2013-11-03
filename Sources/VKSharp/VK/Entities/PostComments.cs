using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class PostComments:IVKEntity<PostComments> {
        public uint Count { get; set; }
        public bool? CanPost { get; set; }
        public IVKEntityParser<PostComments> GetParser() {
            return PostCommentsParser.Instanse;
        }
    }
}
