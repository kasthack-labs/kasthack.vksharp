using VKSharp.Core.Interfaces;

namespace VKSharp.Helpers.PrimitiveEntities {
    public class SimpleEntity<T> : IVKEntity<SimpleEntity<T>> where T : class {
        public VKApi Context { get; set; }
        public T Data { get; set; }
    }
}