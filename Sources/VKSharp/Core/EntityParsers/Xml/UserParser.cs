using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UserParser : DefaultParser<User> {
        public override User ParseFromXml( XElement node ) {
            return //String.CompareOrdinal( node.Name.ToString(), "user" ) != 0
                //? null
                //:
                ParseFromXmlFragments(node.Elements());
        }
        public override User ParseFromXmlFragments(IEnumerable<XElement> nodes) {
            var u = new User {
                ProfilePhotos = new ProfilePhotos(),
                Connections = new SiteProfiles(),
                Counters = new ProfileCounters(),
            };
            FillFromXml(nodes, u );
            return u;
        }


        public override bool UpdateFromFragment(XElement node, User entity) {
            Action<User, string> parser;
            var nodeName = node.Name.ToString();
            if (GeneratedParsers.TryGetValue(nodeName, out parser)) {
                parser(entity, node.Value);
                return true;
            }
            if ( GetP<ProfilePhotos>().UpdateFromFragment( node, entity.ProfilePhotos )
                 || GetP<SiteProfiles>().UpdateFromFragment( node, entity.Connections ) )
                return true;
            var changed = true;
            switch ( nodeName ) {
                case "counters":
                    GetP<ProfileCounters>().FillFromXml( node.Elements(), entity.Counters );
                    break;
                case "schools":
                    entity.Schools = GetP<School>().ParseAllFromXml( node.Elements() );
                    break;
                case "universities":
                    entity.Universities = GetP<University>().ParseAllFromXml( node.Elements() );
                    break;
                case "lists":
                    entity.Lists = node.Value.Split( ',' ).Select( uint.Parse ).ToArray();
                    break;
                //case "ban_info":
                //    this.GetP<BanInfo>().FillFromXml( node.Elements(), entity. );
                //    break;
                case "exports":
                    entity.Exports = GetP<Exports>().ParseFromXml( node );
                    break;
                case "country":
                    entity.Country = GetP<GeoEntry>().ParseFromXml( node );
                    break;
                case "city":
                    entity.City = GetP<GeoEntry>().ParseFromXml( node );
                    break;
                case "relatives":
                    entity.Relatives = GetP<Relative>().ParseAllFromXml( node.Elements() );
                    break;
                case "last_seen":
                    entity.LastSeen = GetP<LastSeen>().ParseFromXml( node );
                    break;
                case "occupation":
                    entity.Occupation = GetP<Occupation>().ParseFromXml( node );
                    break;
                case "personal":
                    entity.Personal = GetP<StandInLife>().ParseFromXml( node );
                    break;
                default:
                    changed=false;
                    break;
            }
            return changed;
        }
    }
}
