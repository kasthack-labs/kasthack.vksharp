using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class MemberShip : IVKEntity<MemberShip> {
        public VKApi Context { get; set; }

        public uint UserId { get; set; }
        public bool Member { get; set; }
        public bool Request { get; set; }
        public bool Invitation { get; set; }
    }
}
