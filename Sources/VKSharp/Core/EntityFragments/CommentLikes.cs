using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class CommentLikes:IVKEntity<CommentLikes> {
        public uint Count { get; set; }
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }
        public bool? CanPublish { get; set; }
    }
}
