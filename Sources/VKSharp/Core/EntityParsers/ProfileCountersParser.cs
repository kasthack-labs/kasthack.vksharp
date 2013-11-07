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

        public ProfileCounters ParseFromXml( XmlNode node ) {
            var pc = new ProfileCounters();
            foreach (XmlNode cn in node.ChildNodes) {
                switch ( cn.Name ) {
                    case "albums":
                        pc.Albums = uint.Parse( cn.InnerText );
                        break;
                    case "videos":
                        pc.Videos = uint.Parse( cn.InnerText );
                        break;
                    case "audios":
                        pc.Audios = uint.Parse( cn.InnerText );
                        break;
                    case "photos":
                        pc.Photos = uint.Parse( cn.InnerText );
                        break;
                    case "notes":
                        pc.Notes = uint.Parse( cn.InnerText );
                        break;
                    case "friends":
                        pc.Friends = uint.Parse( cn.InnerText );
                        break;
                    case "groups":
                        pc.Groups = uint.Parse( cn.InnerText );
                        break;
                    case "online_friends":
                        pc.OnlineFriends = uint.Parse( cn.InnerText );
                        break;
                    case "mutual_friends":
                        pc.MutualFriends = uint.Parse( cn.InnerText );
                        break;
                    case "user_videos":
                        pc.UserVideos = uint.Parse( cn.InnerText );
                        break;
                    case "followers":
                        pc.Followers = uint.Parse( cn.InnerText );
                        break;
                    case "user_photos":
                        pc.UserPhotos = uint.Parse( cn.InnerText );
                        break;
                    case "subscriptions":
                        pc.Subscriptions = uint.Parse( cn.InnerText );
                        break;
                    case "pages":
                        pc.Pages = uint.Parse( cn.InnerText );
                        break;
                }
            }
            return pc;
        }

        public ProfileCounters[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
    }
}