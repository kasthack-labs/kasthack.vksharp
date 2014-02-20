using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class ProfilePhotos : IVKEntity<ProfilePhotos> {
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
        public string PhotoMax { get; set; }
        public string Photo400Orig { get; set; }
        public string Photo200Orig { get; set; }
        public string PhotoMaxOrig { get; set; }

        public VKApi Context { get; set; }
    }
}