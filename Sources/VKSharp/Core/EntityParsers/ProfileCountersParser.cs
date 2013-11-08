using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class ProfileCountersParser:IVKEntityParser<ProfileCounters> {
         private static readonly Lazy<ProfileCountersParser> Lazy = new Lazy<ProfileCountersParser>( () => new ProfileCountersParser() );
        public static ProfileCountersParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private ProfileCountersParser() { }

        public void FillFromXml( IEnumerable<XmlNode> nodes, ref ProfileCounters entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, ref entity );
        }

        public ProfileCounters ParseFromXml( XmlNode node ) {
            if ( String.CompareOrdinal( node.Name, "counters" ) != 0 )
                return null;
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public ProfileCounters[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where(a=>a!=null).ToArray();
        }

        public ProfileCounters ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var pc = new ProfileCounters();
            this.FillFromXml(nodes, ref pc);
            return pc;
        }

        public void UpdateFromFragment(XmlNode node, ref ProfileCounters entity) {
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