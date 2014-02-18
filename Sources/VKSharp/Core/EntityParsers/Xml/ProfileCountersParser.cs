using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class ProfileCountersParser : IXmlVKEntityParser<ProfileCounters> {
        public IExecutor Executor { get; set; }

        public void FillFromXml( IEnumerable<XmlNode> nodes, ProfileCounters entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public ProfileCounters ParseFromXml( XmlNode node ) {
            return String.CompareOrdinal( node.Name, "counters" ) != 0 ? null : this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public ProfileCounters[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where(a=>a!=null).ToArray();
        }

        public ProfileCounters ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var pc = new ProfileCounters();
            this.FillFromXml(nodes, pc);
            return pc;
        }

        public void UpdateFromFragment(XmlNode node, ProfileCounters entity) {
            switch ( node.Name ) {
                case "albums":
                    entity.Albums = uint.Parse( node.InnerText );
                    break;
                case "videos":
                    entity.Videos = uint.Parse( node.InnerText );
                    break;
                case "audios":
                    entity.Audios = uint.Parse( node.InnerText );
                    break;
                case "photos":
                    entity.Photos = uint.Parse( node.InnerText );
                    break;
                case "notes":
                    entity.Notes = uint.Parse( node.InnerText );
                    break;
                case "friends":
                    entity.Friends = uint.Parse( node.InnerText );
                    break;
                case "groups":
                    entity.Groups = uint.Parse( node.InnerText );
                    break;
                case "online_friends":
                    entity.OnlineFriends = uint.Parse( node.InnerText );
                    break;
                case "mutual_friends":
                    entity.MutualFriends = uint.Parse( node.InnerText );
                    break;
                case "user_videos":
                    entity.UserVideos = uint.Parse( node.InnerText );
                    break;
                case "followers":
                    entity.Followers = uint.Parse( node.InnerText );
                    break;
                case "user_photos":
                    entity.UserPhotos = uint.Parse( node.InnerText );
                    break;
                case "subscriptions":
                    entity.Subscriptions = uint.Parse( node.InnerText );
                    break;
                case "pages":
                    entity.Pages = uint.Parse( node.InnerText );
                    break;
            }
        }

    }
}