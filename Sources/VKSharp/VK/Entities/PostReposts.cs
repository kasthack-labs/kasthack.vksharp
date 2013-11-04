using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class PostReposts:IVKEntity<PostReposts> {
        public uint Count { get; set; }
        public bool? UserReposted { get; set; }
        public IVKEntityParser<PostReposts> GetParser() {
            return PostRepostsParser.Instanse;
        }
    }
}
