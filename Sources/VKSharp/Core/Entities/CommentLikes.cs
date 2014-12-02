using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class CommentLikes:IVKEntity<CommentLikes> {
        public uint Count { get; set; }
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }

        
    }
}
