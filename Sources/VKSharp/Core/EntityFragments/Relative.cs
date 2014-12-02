using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityFragments {
    public class Relative:IVKEntity<Relative> {
        public int? Id { get; set; }
        public string Name { get; set; }
        public RelativeType Type;
        
    }
}