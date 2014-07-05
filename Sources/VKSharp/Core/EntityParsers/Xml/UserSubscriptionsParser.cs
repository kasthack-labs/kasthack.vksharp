using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Core.EntityParsers.Xml
{
    public class UserSubscriptionsParser : DefaultParser<UserSubscriptions> {
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
