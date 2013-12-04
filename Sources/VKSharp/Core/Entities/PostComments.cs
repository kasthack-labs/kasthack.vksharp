using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostComments:IVKEntity<PostComments> {
                public uint Count { get; set; }
        public bool? CanPost { get; set; }

        public VKApi Context { get; set; }
    }
}
