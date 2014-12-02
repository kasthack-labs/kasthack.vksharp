using VKSharp.Core.Interfaces;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityFragments {
    public class Occupation : IVKEntity<Occupation> {
        public uint Id {get;set;}
        public string Name {get;set;}
        public OccupationType Type { get; set;}
    }
}

