using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class LastSeen:IVKEntity<LastSeen> {
        public uint Time { get; set; }
        public VKPlatform Platform { get; set; }

        public VKApi Context { get; set; }
    }
}