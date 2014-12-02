using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities
{
    public class UserSubscriptions : IVKEntity<UserSubscriptions> {
        
        public EntityList<uint> Users { get; set; }
        public EntityList<uint> Groups { get; set; }
    }
}
