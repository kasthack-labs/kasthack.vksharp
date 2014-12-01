using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class EntityListParser<T> : DefaultParser<EntityList<T>> where T : IVKEntity<T> {
        public override bool UpdateFromFragment( XElement node, EntityList<T> entity ) {
            switch ( node.Name.ToString() ) {
                case "items":
                    entity.Items =  ( (SimpleXMLExecutor) Executor )
                        .GetParser<T>()
                        .ParseAllFromXml(node.Elements());
                    break;
                default:
                    return base.UpdateFromFragment( node, entity );
            }
            return true;
        }
    }
}
