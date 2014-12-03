using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class PostComments:IVKEntity<PostComments> {
        public uint Count { get; set; }
        public bool? CanPost { get; set; }
    }
}
