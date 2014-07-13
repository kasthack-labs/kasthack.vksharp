using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostLikes : Counter, IVKEntity<PostLikes> {
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }
        public bool? CanPublish { get; set; }
    }
}
