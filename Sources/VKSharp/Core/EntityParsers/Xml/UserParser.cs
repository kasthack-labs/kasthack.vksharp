using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UserParser : DefaultParser<User> {
        private static object _userParserLocker = false;
        public UserParser() {
            lock (_userParserLocker) {
                if((bool)_userParserLocker) return;
                var v = GeneratedParsers;
                _userParserLocker = true;
            }
        }
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

        private IXmlVKEntityParser<T> GetP<T>() where T : IVKEntity<T> {
            return ( (SimpleXMLExecutor) this.Executor ).GetParser<T>();
        }

        public override bool UpdateFromFragment(XElement node, User entity) {
            Action<User, string> parser;
            var nodeName = node.Name.ToString();
            if ( this.GetP<ProfilePhotos>().UpdateFromFragment( node, entity.ProfilePhotos )
                 || this.GetP<SiteProfiles>().UpdateFromFragment( node, entity.Connections ) )
                return true;
            var changed = true;
            switch ( nodeName ) {
                case "bdate":
                    entity.BDate = Date.Parse( node.Value );
                    break;
                case "relation":
                    entity.Relation = (Relation) int.Parse( node.Value );
                    break;
                case "sex":
                    entity.Sex = (Sex) int.Parse( node.Value );
                    break;
                case "counters":
                    this.GetP<ProfileCounters>()
                        .FillFromXml( node.Elements(), entity.Counters );
                    break;
                case "schools":
                    entity.Schools = this.GetP<School>()
                        .ParseAllFromXml( node.Elements() );
                    break;
                case "universities":
                    entity.Universities = this.GetP<University>()
                        .ParseAllFromXml( node.Elements() );
                    break;
                case "deactivated":
                    Deleted d;
                    entity.Deactivated = Enum.TryParse( node.Value, true, out d )
                        ? (Deleted?) d
                        : null;
                    break;
                case "lists":
                    entity.Lists = node.Value.Split( ',' ).Select( uint.Parse ).ToArray();
                    break;
                //case "ban_info":
                //    this.GetP<BanInfo>().FillFromXml( node.Elements(), entity. );
                //    break;
                case "last_seen":
                    entity.LastSeen = this.GetP<LastSeen>().ParseFromXml( node );
                    break;
                default:
                    changed=false;
                    break;
            }
            if ( changed ) return true;
            if ( !GeneratedParsers.TryGetValue( nodeName, out parser ) ) return false;
            parser( entity, node.Value );
            return true;
        }
    }
}
