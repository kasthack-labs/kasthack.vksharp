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
