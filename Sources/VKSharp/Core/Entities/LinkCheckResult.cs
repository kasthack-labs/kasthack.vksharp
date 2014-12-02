using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class LinkCheckResult :IVKEntity<LinkCheckResult> {
        

        public string Link { get; set; }
        public LinkCheckStatus Status{ get; set; }
    }
}
