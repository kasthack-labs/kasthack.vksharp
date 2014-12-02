using System.Collections;
using System.Collections.Generic;
using VKSharp.Core.Interfaces;
using System.Xml.Serialization;
namespace VKSharp.Core.Entities {
    public class EntityList<T>: /*IEnumerable<T>,*/ IVKEntity<EntityList<T>> where T:IVKEntity<T> {
        [XmlElement("Count")]
        public uint TotalCount { get; set; }
        public List<T> Items { get; set; }
        //public IEnumerator<T> GetEnumerator() { return Items.GetEnumerator(); }
        //IEnumerator IEnumerable.GetEnumerator() { return Items.GetEnumerator(); }

        public T this[ int key ] {
            get {
                return Items[ key ];
            }
            set {
                Items[ key ] = value;
            }
        }
        //xmlserializer workaround
        //public void Add( T value ) {
        //    Items.Add( value );
        //}
    }
}
