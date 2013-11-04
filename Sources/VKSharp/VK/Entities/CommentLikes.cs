using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class CommentLikes:IVKEntity<CommentLikes> {
        public uint Count { get; set; }
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }
        public IVKEntityParser<CommentLikes> GetParser() {
            return CommentLikesParser.Instanse;
        }
    }
}
