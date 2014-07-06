using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using System.Xml.XPath;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UserParser : DefaultParser<User> {
        public override User ParseFromXml( XElement node ) {
            return String.CompareOrdinal( node.Name.ToString(), "user" ) != 0
                ? null
                : this.ParseFromXmlFragments(node.Elements());
        }
        public override User ParseFromXmlFragments(IEnumerable<XElement> nodes) {
            var u = new User {
                ProfilePhotos = new ProfilePhotos(),
                Connections = new SiteProfiles(),
                Counters = new ProfileCounters(),
            };
            this.FillFromXml(nodes, u );
            return u;
        }


        public override bool UpdateFromFragment(XElement node, User entity) {
            Action<User, string> parser;
            var nodeName = node.Name.ToString();
            if (GeneratedParsers.TryGetValue(nodeName, out parser)) {
                parser(entity, node.Value);
                return true;
            }
            if ( this.GetP<ProfilePhotos>().UpdateFromFragment( node, entity.ProfilePhotos )
                 || this.GetP<SiteProfiles>().UpdateFromFragment( node, entity.Connections ) )
                return true;
            var changed = true;
            switch ( nodeName ) {
                case "counters":
                    this.GetP<ProfileCounters>().FillFromXml( node.Elements(), entity.Counters );
                    break;
                case "schools":
                    entity.Schools = this.GetP<School>().ParseAllFromXml( node.Elements() );
                    break;
                case "universities":
                    entity.Universities = this.GetP<University>().ParseAllFromXml( node.Elements() );
                    break;
                case "lists":
                    entity.Lists = node.Value.Split( ',' ).Select( uint.Parse ).ToArray();
                    break;
                //case "ban_info":
                //    this.GetP<BanInfo>().FillFromXml( node.Elements(), entity. );
                //    break;
                case "exports":
                    entity.Exports = this.GetP<Exports>().ParseFromXml( node );
                    break;
                case "country":
                    entity.Country = this.GetP<GeoEntry>().ParseFromXml( node );
                    break;
                case "city":
                    entity.City = this.GetP<GeoEntry>().ParseFromXml( node );
                    break;
                case "relatives":
                    entity.Relatives = this.GetP<Relative>().ParseAllFromXml( node.Elements() );
                    break;
                case "last_seen":
                    entity.LastSeen = this.GetP<LastSeen>().ParseFromXml( node );
                    break;
                case "occupation":
                    entity.Occupation = this.GetP<Occupation>().ParseFromXml( node );
                    break;
                case "personal":
                    entity.Personal = this.GetP<StandInLife>().ParseFromXml( node );
                    break;
                default:
                    changed=false;
                    break;
            }
            return changed;
        }
    }
}
