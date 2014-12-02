using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class SiteProfiles : IVKEntity<SiteProfiles> {
        public string Skype { get; set; }
        public ulong? Facebook { get; set; }
        public string FacebookName { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LiveJournal { get; set; }

        
    }
}