using VKSharp.VK.EntityFragments;
using VKSharp.VK.EntityParsers;
using VKSharp.VK.Helpers.DataTypes;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class VKUser:IVKEntity<VKUser> {

        public ProfilePhotos ProfilePhotos;
        public SiteProfiles SiteProfiles;
        public ProfileCounters Counters;

        public uint ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex? Sex { get; set; }
        public Date BDate { get; set; }
        public uint? City { get; set; }
        public uint? Country { get; set; }
        public bool? Online { get; set; }
        public string ScreeName { get; set; }
        public bool? HasMobile { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Activity { get; set; }
        public uint? LastSeen { get; set; }
        public bool? Verified { get; set; }
        public uint? University { get; set; }
        public string UniversityName { get; set; }
        public uint? Faculty { get; set; }
        public string FacultyName { get; set; } 
        public uint? Graduation { get; set; }
        public Relation? Relation { get; set; }
        public VKUniversity[] Universities { get; set; }
        public VKSchool[] Schools { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
        public string Status { get; set; }
        public IVKEntityParser<VKUser> GetParser() {
            return VKUserParser.Instanse;
        }
    }
}
