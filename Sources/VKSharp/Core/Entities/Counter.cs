using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Counter : IVKEntity<Counter> {
        public VKApi Context { get; set; }
        public uint Count { get; set; }
    }
}
