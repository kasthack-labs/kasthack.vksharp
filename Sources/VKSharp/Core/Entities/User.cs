using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Helpers;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.Entities {
    public class User : IEquatable<User> {
        public Audio StatusAudio { get; set; }
        public bool? Blacklisted { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
        public Deleted? Deactivated { get; set; }
        public bool? HasMobile { get; set; }
        public bool Hidden { get; set; }
        public bool? Online { get; set; }
        public bool? OnlineMobile { get; set; }
        public bool? Verified { get; set; }
        public bool? WallComments { get; set; }
        public byte? Timezone { get; set; }
        public Date? Bdate { get; set; }
        public Exports Exports { get; set; } = new Exports();
        public LastSeen LastSeen { get; set; }
        public Occupation Occupation { get; set; }
        public ProfileCounters Counters { get; set; } = new ProfileCounters();
        [FlatMap]
        public ProfilePhotos ProfilePhotos { get; set; } = new ProfilePhotos();
        #region ProfilePhotos proxies
        private string Photo50 { get { return ProfilePhotos.Photo50; } set { ProfilePhotos.Photo50 = value; } }
        private string Photo100 { get { return ProfilePhotos.Photo100; } set { ProfilePhotos.Photo100 = value; } }
        private string Photo200 { get { return ProfilePhotos.Photo200; } set { ProfilePhotos.Photo200 = value; } }
        private string PhotoMax { get { return ProfilePhotos.PhotoMax; } set { ProfilePhotos.PhotoMax = value; } }
        private string Photo400Orig { get { return ProfilePhotos.Photo400Orig; } set { ProfilePhotos.Photo400Orig = value; } }
        private string Photo200Orig { get { return ProfilePhotos.Photo200Orig; } set { ProfilePhotos.Photo200Orig = value; } }
        private string PhotoMaxOrig { get { return ProfilePhotos.PhotoMaxOrig; } set { ProfilePhotos.PhotoMaxOrig = value; } }
        private string PhotoId { get { return ProfilePhotos.PhotoId; } set { ProfilePhotos.PhotoId = value; } }
        #endregion
        public Relation? Relation { get; set; }
        public Relative[] Relatives { get; set; }
        public School[] Schools { get; set; }
        public Sex? Sex { get; set; }
        [FlatMap]
        public SiteProfiles Connections { get; set; } = new SiteProfiles();
        //todo: fix serializer & remove code
        #region SiteProfiles proxies
        private string Skype { get { return Connections.Skype; } set { Connections.Skype = value; } }
        private ulong? Facebook { get { return Connections.Facebook; } set { Connections.Facebook = value; } }
        private string FacebookName { get { return Connections.FacebookName; } set { Connections.FacebookName = value; } }
        private string Twitter { get { return Connections.Twitter; } set { Connections.Twitter = value; } }
        private string Instagram { get { return Connections.Instagram; } set { Connections.Instagram = value; } }
        private string LiveJournal { get { return Connections.LiveJournal; } set { Connections.LiveJournal = value; } }
        #endregion
        public string About { get; set; }
        public string Activities { get; set; }
        public string Books { get; set; }
        public string Domain { get; set; }
        public string FirstName { get; set; }
        public string Games { get; set; }
        public string HomePhone { get; set; }
        public string HomeTown { get; set; }
        public string Interests { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string MobilePhone { get; set; }
        public string Movies { get; set; }
        public string Music { get; set; }
        public string Nickname { get; set; }
        public string Quotes { get; set; }
        public string ScreenName { get; set;}
        public string Site { get; set; }
        public string Status { get; set; }
        public string Tv { get; set; }
        [JsonConverter(typeof(PersonalConverter))]
        public StandInLife Personal { get; set; }
        public uint? CommonCount { get; set; }
        public int Id { get; set; }
        public GeoEntry City { get; set; }
        public GeoEntry Country { get; set; }

        public University MainUniversity { get; set; } = new University();
        #region Main university
        private string UniversityName {
            get {
                return MainUniversity.Name;
            }
            set {
                MainUniversity.Name = value;
            }
        }
        private string FacultyName {
            get {
                return MainUniversity.FacultyName;
            }
            set {
                MainUniversity.FacultyName = value;
            }
        }
        private int? Faculty {
            get {
                return MainUniversity.Faculty;
            }
            set {
                MainUniversity.Faculty = value;
            }
        }
        private int? University {
            get {
                return MainUniversity?.Id;
            }
            set {
                if (value!=null)
                    MainUniversity.Id = (int) value;
            }
        }
        private int? Graduation {
            get {
                return MainUniversity.Graduation;
            }
            set {
                MainUniversity.Graduation = value;
            }
        }
        #endregion
        public int? FollowersCount { get; set; }
        public int? OnlineApp { get; set; }
        public int[] Lists { get; set; }
        public University[] Universities { get; set; }
        
        public bool Equals( User other ) => !ReferenceEquals( other, null ) && Id == other.Id;

        public static bool operator ==( User a, User b ) => ReferenceEquals( a, null )
                                                                ? ReferenceEquals( b, null )
                                                                : ( a.Equals( b ) );

        public static bool operator !=( User a, User b ) => !( a == b );

        public override int GetHashCode() => Id;
        public override string ToString() => "ID :" + Id;
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class FlatMap : Attribute { }
}
