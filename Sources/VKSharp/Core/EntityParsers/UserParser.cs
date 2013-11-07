using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.EntityParsers {
    public class UserParser : IVKEntityParser<User> {
        private static readonly Lazy<UserParser> Lazy = new Lazy<UserParser>( () => new UserParser() );
        public static UserParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private UserParser() { }

        public User ParseFromXml( XmlNode node ) {
            var u = new User() {
                ProfilePhotos = new ProfilePhotos(),
                SiteProfiles = new SiteProfiles(),
                Counters = new ProfileCounters()
            };
            foreach ( XmlNode cn in node.ChildNodes ) {
                switch ( cn.Name ) {
                    case "can_post":
                        u.CanPost = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "can_see_all_posts":
                        u.CanSeeAllPosts = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "can_see_audio":
                        u.CanSeeAudio = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "can_write_private_message":
                        u.CanWritePrivateMessage = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "has_mobile":
                        u.HasMobile = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "online":
                        u.Online = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "verified":
                        u.Verified = int.Parse( cn.InnerText ) == 1;
                        break;
                    case "bdate":
                        u.BDate = Date.Parse( cn.InnerText );
                        break;

                    case "activity":
                        u.Activity = cn.InnerText;
                        break;
                    case "faculty_name":
                        u.FacultyName = cn.InnerText;
                        break;
                    case "first_name":
                        u.FirstName = cn.InnerText;
                        break;
                    case "interests":
                        u.Interests = cn.InnerText;
                        break;
                    case "movies":
                        u.Movies = cn.InnerText;
                        break;
                    case "tv":
                        u.Tv = cn.InnerText;
                        break;
                    case "books":
                        u.Books = cn.InnerText;
                        break;
                    case "games":
                        u.Games = cn.InnerText;
                        break;
                    case "home_phone":
                        u.HomePhone = cn.InnerText;
                        break;
                    case "last_name":
                        u.LastName = cn.InnerText;
                        break;
                    case "mobile_phone":
                        u.MobilePhone = cn.InnerText;
                        break;
                    case "screen_name":
                        u.ScreenName = cn.InnerText;
                        break;
                    case "status":
                        u.Status = cn.InnerText;
                        break;
                    case "university_name":
                        u.UniversityName = cn.InnerText;
                        break;

                    case "uid":
                        u.ID = uint.Parse( cn.InnerText );
                        break;
                    case "city":
                        u.City = uint.Parse( cn.InnerText );
                        break;
                    case "country":
                        u.Country = uint.Parse( cn.InnerText );
                        break;
                    case "faculty":
                        u.Faculty = uint.Parse( cn.InnerText );
                        break;
                    case "graduation":
                        u.Graduation = uint.Parse( cn.InnerText );
                        break;
                    case "last_seen":
                        u.LastSeen = uint.Parse( cn.InnerText );
                        break;
                    case "university":
                        u.University = uint.Parse( cn.InnerText );
                        break;

                    case "photo_50":
                        u.ProfilePhotos.Photo50 = cn.InnerText;
                        break;
                    case "photo_100":
                        u.ProfilePhotos.Photo100 = cn.InnerText;
                        break;
                    case "photo_200":
                        u.ProfilePhotos.Photo200 = cn.InnerText;
                        break;
                    case "photo_max":
                        u.ProfilePhotos.PhotoMax = cn.InnerText;
                        break;
                    case "photo_200_orig":
                        u.ProfilePhotos.Photo200Orig = cn.InnerText;
                        break;
                    case "photo_400_orig":
                        u.ProfilePhotos.Photo400Orig = cn.InnerText;
                        break;
                    case "photo_max_orig":
                        u.ProfilePhotos.PhotoMaxOrig = cn.InnerText;
                        break;

                    case "skype":
                        u.SiteProfiles.Skype = cn.InnerText;
                        break;
                    case "facebook":
                        u.SiteProfiles.Facebook = ulong.Parse( cn.InnerText );
                        break;
                    case "facebook_name":
                        u.SiteProfiles.FacebookName = cn.InnerText;
                        break;
                    case "twitter":
                        u.SiteProfiles.Twitter = cn.InnerText;
                        break;
                    case "instagram":
                        u.SiteProfiles.Instagram = cn.InnerText;
                        break;

                    case "counters":
                        u.Counters = u.Counters.GetParser().ParseFromXml( cn );
                        break;

                    case "relation":
                        u.Relation = (Relation) int.Parse(cn.InnerText);
                        break;
                    case "sex":
                        u.Sex = (Sex) int.Parse( cn.InnerText );
                        break;

                    case "schools":
                        u.Schools = new School().GetParser().ParseAllFromXml(cn.ChildNodes.OfType<XmlNode>());
                        break;
                    case "universities":
                        u.Universities = new University().GetParser().ParseAllFromXml( cn.ChildNodes.OfType<XmlNode>() );
                        break;
                }
            }
            return u;
        }

        public User[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
    }
}
