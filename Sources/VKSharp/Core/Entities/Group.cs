using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;

namespace VKSharp.Core.Entities {
    public class Group {
        
        public bool IsAdmin { get; set; }
        public bool IsClosed { get; set; }
        public Deleted? Deactivated { get; set; }
        public string Activity { get; set; }
        public bool IsMember { get; set; }
        public bool? CanCreateTopic { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanUploadDoc { get; set; }
        public bool? CanUploadVideo { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? Verified { get; set; }
        public GroupAdminLevel AdminLevel { get; set; }
        public GroupCounters Counters { get; set; }
        public PageType PageType { get; set; }
        public Place Place { get; set; }
        public ProfilePhotos Photos { get; set; }
        //todo: photos mapping(50,100,200)
        public string Contacts { get; set; }
        public string Description { get; set; }
        public string Links { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public string WikiPage { get; set; }
        public int Id { get; set; }
        public int? City { get; set; }
        public int? Country { get; set; }
        public int? EndDate { get; set; }
        public int? MembersCount { get; set; }
        public int? PostId { get; set; }
        public int? StartDate { get; set; }
        public int? FinishDate { get; set; }
        public int? FixedPost { get; set; }
        public long? MainAlbumId { get; set; }


    }
}
