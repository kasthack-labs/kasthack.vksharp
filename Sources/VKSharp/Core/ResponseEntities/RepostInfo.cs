using VKSharp.Core.Interfaces;

namespace VKSharp.Core.ResponseEntities
{
    public class RepostInfo : IVKEntity<RepostInfo> {
        
        public bool Success { get; set; }
        public int PostId { get; set; }
        public int RepostCount { get; set; }
        public int LikesCount { get; set; }
    }
}
