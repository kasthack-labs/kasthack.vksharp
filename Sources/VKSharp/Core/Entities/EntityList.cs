using System.Collections.Generic;

namespace VKSharp.Core.Entities {
    public class EntityList<T> /*IEnumerable<T>,*/{
        public int Count { get; set; }
        public T[] Items { get; set; }
        public IEnumerator<T> GetEnumerator() { return (IEnumerator<T>) Items.GetEnumerator(); }
    }
}
