using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostLikes : IVKEntity<PostLikes> {
        public uint Count { get; set; }
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }
        public bool? CanPublish { get; set; }

        public VKApi Context { get; set; }
    }
}
