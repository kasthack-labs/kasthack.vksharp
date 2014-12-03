using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Counter : IVKEntity<Counter> {
        public uint Count { get; set; }
    }
}
