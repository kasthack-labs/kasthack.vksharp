using System.Linq;
using System.Xml;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class EntityListParser<T> : DefaultParser<EntityList<T>> where T : IVKEntity<T> {
        public override bool UpdateFromFragment( XElement node, EntityList<T> entity ) {
            switch ( node.Name.ToString() ) {
                case "count":
                    entity.TotalCount = uint.Parse( node.Value );
                    break;
                case "items":
                    entity.Items =  ( (SimpleXMLExecutor) this.Executor )
                        .GetParser<T>()
                        .ParseAllFromXml(node.Elements());
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
