using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UserParser : IXmlVKEntityParser<User> {
        private static readonly Lazy<UserParser> Lazy = new Lazy<UserParser>( () => new UserParser() );
        public static UserParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private UserParser() { }

        public void FillFromXml( IEnumerable<XmlNode> nodes, ref User entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, ref entity );
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
                SiteProfiles = new SiteProfiles(),
                Counters = new ProfileCounters()
            };
            this.FillFromXml(nodes, ref u);
            return u;
        }

        public void UpdateFromFragment(XmlNode node, ref User entity) {
            switch ( node.Name ) {
                case "can_post":
                    entity.CanPost = int.Parse( node.InnerText ) == 1;
                    break;
                case "can_see_all_posts":
                    entity.CanSeeAllPosts = int.Parse( node.InnerText ) == 1;
                    break;
                case "can_see_audio":
                    entity.CanSeeAudio = int.Parse( node.InnerText ) == 1;
                    break;
                case "can_write_private_message":
                    entity.CanWritePrivateMessage = int.Parse( node.InnerText ) == 1;
                    break;
                case "has_mobile":
                    entity.HasMobile = int.Parse( node.InnerText ) == 1;
                    break;
                case "online":
                    entity.Online = int.Parse( node.InnerText ) == 1;
                    break;
                case "verified":
                    entity.Verified = int.Parse( node.InnerText ) == 1;
                    break;
                case "bdate":
                    entity.BDate = Date.Parse( node.InnerText );
                    break;

                case "activity":
                    entity.Activity = node.InnerText;
                    break;
                case "faculty_name":
                    entity.FacultyName = node.InnerText;
                    break;
                case "first_name":
                    entity.FirstName = node.InnerText;
                    break;
                case "interests":
                    entity.Interests = node.InnerText;
                    break;
                case "movies":
                    entity.Movies = node.InnerText;
                    break;
                case "tv":
                    entity.Tv = node.InnerText;
                    break;
                case "books":
                    entity.Books = node.InnerText;
                    break;
                case "games":
                    entity.Games = node.InnerText;
                    break;
                case "home_phone":
                    entity.HomePhone = node.InnerText;
                    break;
                case "last_name":
                    entity.LastName = node.InnerText;
                    break;
                case "mobile_phone":
                    entity.MobilePhone = node.InnerText;
                    break;
                case "screen_name":
                    entity.ScreenName = node.InnerText;
                    break;
                case "status":
                    entity.Status = node.InnerText;
                    break;
                case "university_name":
                    entity.UniversityName = node.InnerText;
                    break;

                case "uid":
                    entity.ID = uint.Parse( node.InnerText );
                    break;
                case "city":
                    entity.City = uint.Parse( node.InnerText );
                    break;
                case "country":
                    entity.Country = uint.Parse( node.InnerText );
                    break;
                case "faculty":
                    entity.Faculty = uint.Parse( node.InnerText );
                    break;
                case "graduation":
                    entity.Graduation = uint.Parse( node.InnerText );
                    break;
                case "last_seen":
                    entity.LastSeen = uint.Parse( node.InnerText );
                    break;
                case "university":
                    entity.University = uint.Parse( node.InnerText );
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
                    entity.SiteProfiles.Skype = node.InnerText;
                    break;
                case "facebook":
                    entity.SiteProfiles.Facebook = ulong.Parse( node.InnerText );
                    break;
                case "facebook_name":
                    entity.SiteProfiles.FacebookName = node.InnerText;
                    break;
                case "twitter":
                    entity.SiteProfiles.Twitter = node.InnerText;
                    break;
                case "instagram":
                    entity.SiteProfiles.Instagram = node.InnerText;
                    break;

                case "counters":
                    var c = entity.Counters;
                    //var cp = c.GetParser();
                    //cp.FillFromXml(node.ChildNodes.OfType<XmlNode>(), ref c);
                    break;

                case "relation":
                    entity.Relation = (Relation) int.Parse( node.InnerText );
                    break;
                case "sex":
                    entity.Sex = (Sex) int.Parse( node.InnerText );
                    break;

                case "schools":
                    //entity.Schools = new School().GetParser().ParseAllFromXml( node.ChildNodes.OfType<XmlNode>() );
                    break;
                case "universities":
                    //entity.Universities = new University().GetParser().ParseAllFromXml( node.ChildNodes.OfType<XmlNode>() );
                    break;
                case "ban_info":
                    var b = entity.BanInfo;
                    //var bp = b.GetParser();
                    //bp.FillFromXml(node.ChildNodes.OfType<XmlNode>(), ref b);
                    break;
            }
        }
    }
}
