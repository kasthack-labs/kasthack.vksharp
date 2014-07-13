using System;
using System.Xml.Linq;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class SimpleEntityParser<T> : DefaultParser<SimpleEntity<T>> where T : class {
        public override SimpleEntity<T> ParseFromXml(XElement node) {
            var se = new SimpleEntity<T>();
            UpdateFromFragment( node, se );
            return se;
        }

        public override bool UpdateFromFragment(XElement node, SimpleEntity<T> entity) {
            Action<SimpleEntity<T>, string> p;
            if ( !GeneratedParsers.TryGetValue( "data", out p ) )
                return false;
            p( entity, node.Value );
            return true;
        }
    }
}
