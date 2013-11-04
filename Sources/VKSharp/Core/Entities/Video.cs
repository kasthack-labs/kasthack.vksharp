using VKSharp.Core.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class Video : OwnedEntity<Video> {
        public string Title { get; set; }
        public uint Duration { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Photo130 { get; set; }
        public string Photo320 { get; set; }
        public string Photo640 { get; set; }
        public uint Date { get; set; }
        public uint Views { get; set; }
        public uint Comments { get; set; }
        public string Player { get; set; }
        public Privacy PrivacyView { get; set; }
        public Privacy PrivacyComment { get; set; }
        public bool? CanComment { get; set; }
        public bool? CanRepost { get; set; }
        public bool? UserLikes { get; set; }
        public uint? LikesCount { get; set; }
        public bool? PlaybackLooped { get; set; }
        public override IVKEntityParser<Video> GetParser() {
            return VideoParser.Instanse;
        }
    }
}
