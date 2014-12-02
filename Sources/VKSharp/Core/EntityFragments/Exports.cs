using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class Exports : IVKEntity<Exports> {
        public bool? Twitter { get; set; }
        public bool? Facebook { get; set; }
        public bool? LiveJournal { get; set; }
        public bool? Instagram { get; set; }
        
    }
}