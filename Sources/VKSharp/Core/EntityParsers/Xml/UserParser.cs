using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UserParser : IXmlVKEntityParser<User> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<User, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<User, string>>>( ParserHelper.GetStringParsers<User> );

        private static Dictionary<string, Action<User, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, User entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public User ParseFromXml( XmlNode node ) {
            return String.CompareOrdinal( node.Name, "user" ) != 0 ? null : this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public User[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public User ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var u = new User {
                ProfilePhotos = new ProfilePhotos(),
                Connections = new SiteProfiles(),
                Counters = new ProfileCounters()
            };
            this.FillFromXml(nodes, u );
            return u;
        }

        public void UpdateFromFragment(XmlNode node, User entity) {
            Action<User, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return;
            }
            switch ( nodeName ) {
                case "bdate":
                    entity.BDate = Date.Parse( node.InnerText );
                    break;
                case "photo_50":
                    entity.ProfilePhotos.Photo50 = node.InnerText;
                    break;
                case "photo_100":
                    entity.ProfilePhotos.Photo100 = node.InnerText;
                    break;
                case "photo_200":
                    entity.ProfilePhotos.Photo200 = node.InnerText;
                    break;
                case "photo_max":
                    entity.ProfilePhotos.PhotoMax = node.InnerText;
                    break;
                case "photo_200_orig":
                    entity.ProfilePhotos.Photo200Orig = node.InnerText;
                    break;
                case "photo_400_orig":
                    entity.ProfilePhotos.Photo400Orig = node.InnerText;
                    break;
                case "photo_max_orig":
                    entity.ProfilePhotos.PhotoMaxOrig = node.InnerText;
                    break;

                case "skype":
                    entity.Connections.Skype = node.InnerText;
                    break;
                case "facebook":
                    entity.Connections.Facebook = ulong.Parse( node.InnerText );
                    break;
                case "facebook_name":
                    entity.Connections.FacebookName = node.InnerText;
                    break;
                case "twitter":
                    entity.Connections.Twitter = node.InnerText;
                    break;
                case "instagram":
                    entity.Connections.Instagram = node.InnerText;
                    break;

                //case "counters":
                //    var p2 = entity.Counters;
                //    var cp = p2.GetParser();
                //    cp.FillFromXml(node.ChildNodes.OfType<XmlNode>(), p2);
                //    break;

                case "relation":
                    entity.Relation = (Relation) int.Parse( node.InnerText );
                    break;
                case "sex":
                    entity.Sex = (Sex) int.Parse( node.InnerText );
                    break;

                //case "schools":
                //    entity.Schools = new School().GetParser().ParseAllFromXml( node.ChildNodes.OfType<XmlNode>() );
                //    break;
                //case "universities":
                //    entity.Universities = new University().GetParser().ParseAllFromXml( node.ChildNodes.OfType<XmlNode>() );
                //    break;
                //case "ban_info":
                //    var b = entity.BanInfo;
                //    var bp = b.GetParser();
                //    bp.FillFromXml(node.ChildNodes.OfType<XmlNode>(), b);
                //    break;
            }
        }
    }
}
