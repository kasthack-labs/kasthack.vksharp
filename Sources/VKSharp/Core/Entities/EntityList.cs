using System.Collections;
using System.Collections.Generic;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class EntityList<T>: IEnumerable<T>, IVKEntity<EntityList<T>> where T:IVKEntity<T> {
        public uint TotalCount { get; set; }
        public T[] Items { get; set; }

        public VKApi Context { get; set; }
        public IEnumerator<T> GetEnumerator() { return ( (IEnumerable<T>) Items ).GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return Items.GetEnumerator(); }

        public T this[ int key ] {
            get {
                return Items[ key ];
            }
            set {
                Items[ key ] = value;
            }
        }
    }
}
