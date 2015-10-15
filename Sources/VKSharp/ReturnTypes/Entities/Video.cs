using System;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Video : OwnedEntity {
        public string AccessKey { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Photo130 { get; set; }
        public string Photo320 { get; set; }
        public string Photo640 { get; set; }
        public DateTimeOffset Date { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }
        public string Player { get; set; }
        public Privacy PrivacyView { get; set; }
        public Privacy PrivacyComment { get; set; }
        public bool? CanComment { get; set; }
        public bool? CanRepost { get; set; }
        public bool? UserLikes { get; set; }
        public int? LikesCount { get; set; }
        public bool? PlaybackLooped { get; set; }
    }

    public class TaggedVideo : Video{
        public int TagId { get; set; }
        public int PlacerId { get; set; }
        public DateTimeOffset TagCreated { get; set; }
    }

}
