using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class EntityList<T>:IVKEntity<EntityList<T>> where T:IVKEntity<T> {
        public uint TotalCount { get; set; }
        public T[] Items { get; set; }

        public VKApi Context { get; set; }
    }
}
