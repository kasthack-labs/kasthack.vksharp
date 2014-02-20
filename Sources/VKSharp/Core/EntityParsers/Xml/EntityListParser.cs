using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class EntityListParser<T> : DefaultParser<EntityList<T>> where T : IVKEntity<T> {
        public override bool UpdateFromFragment(XmlNode node, EntityList<T> entity) {
            switch ( node.Name ) {
                case "count":
                    entity.TotalCount = uint.Parse( node.InnerText );
                    break;
                case "items":
                    entity.Items =  ( (SimpleXMLExecutor) this.Executor )
                        .GetParser<T>()
                        .ParseAllFromXml(node.ChildNodes.OfType<XmlNode>());
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
