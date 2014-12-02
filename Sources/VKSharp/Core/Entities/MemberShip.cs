using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class MemberShip : IVKEntity<MemberShip> {
        

        public uint UserId { get; set; }
        public bool Member { get; set; }
        public bool Request { get; set; }
        public bool Invitation { get; set; }
    }
}
