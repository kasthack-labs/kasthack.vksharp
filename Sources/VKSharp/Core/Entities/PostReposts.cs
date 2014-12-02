using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostReposts : IVKEntity<PostReposts> {
        public uint Count { get; set; }
        public bool? UserReposted { get; set; }

        
    }
}
