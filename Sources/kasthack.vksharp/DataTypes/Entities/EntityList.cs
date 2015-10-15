using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kasthack.vksharp.DataTypes.Entities {
    [JsonObject]
    public class EntityList<T> : IEnumerable<T> {
        public int Count { get; set; }
        public T[] Items { get; set; }

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Items).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ( (IEnumerable) Items ).GetEnumerator();

    }
}
