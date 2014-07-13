using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PhotoLikes : Counter, IVKEntity<PhotoLikes> {
        public bool UserLikes { get; set; }
    }
}