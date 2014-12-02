using VKSharp.Core.Interfaces;

namespace VKSharp.Helpers.PrimitiveEntities {
    public class SimpleEntity<T> : IVKEntity<SimpleEntity<T>> where T : class {
        
        public T Data { get; set; }
    }
}