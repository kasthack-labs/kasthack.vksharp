using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class ProfileCounters:IVKEntity<ProfileCounters> {
                public uint? Albums { get; set; }
        public uint? Videos { get; set; }
        public uint? Audios { get; set; }
        public uint? Photos { get; set; }
        public uint? Notes { get; set; }
        public uint? Friends { get; set; }
        public uint? Groups { get; set; }
        public uint? OnlineFriends { get; set; }
        public uint? MutualFriends { get; set; }
        public uint? UserVideos { get; set; }
        public uint? Followers { get; set; }
        public uint? UserPhotos { get; set; }
        public uint? Subscriptions { get; set; }
        public uint? Pages { get; set; }

        public VKApi Context { get; set; }
    }
}
