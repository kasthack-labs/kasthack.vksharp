using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class GroupCounters : IVKEntity<GroupCounters> {
        public uint? Photos { get; set; }
        public uint? Albums { get; set; }
        public uint? Audios { get; set; }
        public uint? Videos { get; set; }
        public uint? Topics { get; set; }
        public uint? Docs { get; set; }
        
    }
}