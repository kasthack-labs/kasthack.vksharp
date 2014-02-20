using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UserParser : DefaultParser<User> {
        public override User ParseFromXml( XmlNode node ) {
            return String.CompareOrdinal( node.Name, "user" ) != 0 ? null : this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }
        public override User ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var u = new User {
                ProfilePhotos = new ProfilePhotos(),
                Connections = new SiteProfiles(),
                Counters = new ProfileCounters()
            };
            this.FillFromXml(nodes, u );
            return u;
        }

        private IXmlVKEntityParser<T> GetP<T>() where T : IVKEntity<T> {
            return ( (SimpleXMLExecutor) this.Executor ).GetParser<T>();
        }

        public override bool UpdateFromFragment(XmlNode node, User entity) {
            Action<User, string> parser;
            var nodeName = node.Name;
            if ( this.GetP<ProfilePhotos>().UpdateFromFragment( node, entity.ProfilePhotos )
                 || this.GetP<SiteProfiles>().UpdateFromFragment( node, entity.Connections ))
                return true;
            var changed = true;
            switch ( nodeName ) {
                case "bdate":
                    entity.BDate = Date.Parse( node.InnerText );
                    break;
                case "relation":
                    entity.Relation = (Relation) int.Parse( node.InnerText );
                    break;
                case "sex":
                    entity.Sex = (Sex) int.Parse( node.InnerText );
                    break;
                case "counters":
                    this.GetP<ProfileCounters>().FillFromXml( node.ChildNodes.OfType<XmlNode>(), entity.Counters );
                    break;
                case "schools":
                    entity.Schools = this.GetP<School>().ParseAllFromXml( node.ChildNodes.OfType<XmlNode>() );
                    break;
                case "universities":
                    entity.Universities =this.GetP<University>().ParseAllFromXml( node.ChildNodes.OfType<XmlNode>() );
                    break;
                case "deactivated":
                    Deleted d;
                    entity.Deactivated = Enum.TryParse( node.InnerText, true, out d )?(Deleted?)d:null;
                    break;
                //case "ban_info":
                //    this.GetP<BanInfo>().FillFromXml( node.ChildNodes.OfType<XmlNode>(), entity.BanInfo );
                //    break;
                default:
                    changed=false;
                    break;
            }
            if ( changed ) return true;
            if ( !GeneratedParsers.TryGetValue( nodeName, out parser ) ) return false;
            parser( entity, node.InnerText );
            return true;
        }
    }
}
