using System;
using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class PostLikes:IVKEntity<PostLikes> {
        public uint Count { get; set; }
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }
        public bool? CanPublish { get; set; }
        public IVKEntityParser<PostLikes> GetParser() {
            return PostLikesParser.Instanse;
        }
    }
}
