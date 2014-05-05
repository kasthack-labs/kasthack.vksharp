using VKSharp.Core.Interfaces;

namespace VKSharp.Helpers.PrimitiveEntities {
    public class StructEntity<T> : IVKEntity<StructEntity<T>> where T : struct {
        public T? Data { get; set; }

        public VKApi Context { get; set; }
    }
}
