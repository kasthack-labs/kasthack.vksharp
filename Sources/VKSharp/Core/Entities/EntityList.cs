using System.Collections;
using System.Collections.Generic;
using VKSharp.Core.Interfaces;
using System.Xml.Serialization;
namespace VKSharp.Core.Entities {
    public class EntityList<T>: /*IEnumerable<T>,*/ IVKEntity<EntityList<T>> {
        public uint Count { get; set; }
        public T[] Items { get; set; }
        public IEnumerator<T> GetEnumerator() { return (IEnumerator<T>) Items.GetEnumerator(); }
    }
}
