using VKSharp.Core.Interfaces;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Core.Entities
{
    public class UserSubscriptions : IVKEntity<UserSubscriptions> {
        
        public EntityList<StructEntity<uint>> Users { get; set; }
        public EntityList<StructEntity<uint>> Groups { get; set; }
    }
}
