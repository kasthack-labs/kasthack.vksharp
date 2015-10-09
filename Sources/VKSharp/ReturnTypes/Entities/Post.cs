using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Post : OwnedEntity {
        public int FromId { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanPin { get; set; }
        public bool? CanDelete { get; set; }
        public bool IsPinned { get; set; }
        public uint Date { get; set; }
        public string Text { get; set; }
        public int? ReplyOwnerId { get; set; }
        public uint? ReplyPostId { get; set; }
        public bool FriendsOnly { get; set; }
        public PostComments Comments { get; set; }
        public PostLikes Likes { get; set; }
        public PostReposts Reposts { get; set; }
        public PostType PostType { get; set; }
        public PostSource PostSource { get; set; }
        public Attachment[] Attachments { get; set; }
        public Geo Geo { get; set; }
        public uint? SignerId { get; set; }
        public Post[] CopyHistory { get; set; }

        //???
        public Group[] Groups { get; set; }
        public User[] Profiles { get; set; }

        public override string ToString () {
            return $"Post #{Id}@{OwnerId}by{FromId}";
        }
    }
}