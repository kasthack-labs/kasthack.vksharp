using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities
{
    public class Onlines : IVKEntity<Onlines> {
        
        public int?[] Time { get; set; }
        public int?[] Ids { get; set; }
    }
}
