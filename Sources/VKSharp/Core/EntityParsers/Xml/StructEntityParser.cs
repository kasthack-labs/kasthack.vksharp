using System.Xml.Linq;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class StructEntityParser<T>:DefaultParser<StructEntity<T>> where T : struct {
        public override StructEntity<T> ParseFromXml( XElement node ) {
            var se = new StructEntity<T>();
            UpdateFromFragment( node, se );
            return se;
        }

        public override bool UpdateFromFragment( XElement node, StructEntity<T> entity ) {
            GeneratedParsers[ "data" ]( entity, node.Value );
            return true;
        }
    }
}
