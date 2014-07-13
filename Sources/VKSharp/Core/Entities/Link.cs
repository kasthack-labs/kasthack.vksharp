using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Link :IVKEntity<Link> {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageSrc { get; set; }
        public string PreviewPage { get; set; }
        public string PreviewUrl { get; set; }
        public VKApi Context { get; set;}
    }
}

