using VKSharp.Core.Entities;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityFragments {
    public class LastSeen {
        public uint Time { get; set; }
        public VKPlatform Platform { get; set; }
    }
}