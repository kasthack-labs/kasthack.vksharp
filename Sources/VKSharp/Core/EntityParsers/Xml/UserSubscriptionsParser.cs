using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Core.EntityParsers.Xml
{
    public class UserSubscriptionsParser : DefaultParser<UserSubscriptions>
    {
        private IXmlVKEntityParser<T> GetP<T>() where T : IVKEntity<T>
        {
            return ((SimpleXMLExecutor)this.Executor).GetParser<T>();
        }
        public override bool UpdateFromFragment( XElement node, UserSubscriptions entity ) {
            switch ( node.Name.ToString() ) {
                case "users":
                    entity.Users = this.GetP<EntityList<StructEntity<uint>>>().ParseFromXml( node );
                    break;
                case "groups":
                    entity.Groups = this.GetP<EntityList<StructEntity<uint>>>().ParseFromXml( node );
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
