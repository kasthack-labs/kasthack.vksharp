using VKSharp.Core.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostReposts:IVKEntity<PostReposts> {
        public uint Count { get; set; }
        public bool? UserReposted { get; set; }
        public IVKEntityParser<PostReposts> GetParser() {
            return PostRepostsParser.Instanse;
        }
    }
}
