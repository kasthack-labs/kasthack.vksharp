using VKSharp.VK.EntityFragments;
using VKSharp.VK.EntityParsers;
using VKSharp.VK.Helpers.DataTypes;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class User:IVKEntity<User> {

        public ProfilePhotos ProfilePhotos { get; set; }
        public SiteProfiles SiteProfiles { get; set; }
        public ProfileCounters Counters { get; set; }

        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
        public bool? HasMobile { get; set; }
        public bool? Online { get; set; }
        public bool? Verified { get; set; }
        public Date BDate { get; set; }
        public Relation? Relation { get; set; }
        public School[] Schools { get; set; }
        public Sex? Sex { get; set; }
        public string Activity { get; set; }
        public string FacultyName { get; set; }
        public string FirstName { get; set; }
        public string HomePhone { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string ScreeName { get; set; }
        public string Status { get; set; }
        public string UniversityName { get; set; }
        public uint ID { get; set; }
        public uint? City { get; set; }
        public uint? Country { get; set; }
        public uint? Faculty { get; set; }
        public uint? Graduation { get; set; }
        public uint? LastSeen { get; set; }
        public uint? University { get; set; }
        public University[] Universities { get; set; }
        public IVKEntityParser<User> GetParser() {
            return VKUserParser.Instanse;
        }
    }
}
