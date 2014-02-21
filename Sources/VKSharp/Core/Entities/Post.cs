using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Post : IVKEntity<Post> {
                public Attachment[] Attachments { get; set; }
        public bool FriendsOnly { get; set; }
        public Geo Geo { get; set; }
        public Group[] Groups { get; set; }
        public int? CopyOwnerId { get; set; }
        public int FromId { get; set; }
        public int? ReplyOwnerId { get; set; }
        public int ToId { get; set; }
        public Post[] CopyHistory { get; set; }
        public PostComments Comments { get; set; }
        public PostLikes PostLikes { get; set; }
        public PostSource PostSource { get; set; }
        public PostReposts Reposts { get; set; }
        public PostType? CopyPostType { get; set; }
        public PostType PostType { get; set; }
        public string CopyText { get; set; }
        public string Text { get; set; }
        public uint Date { get; set; }
        public uint? CopyPostDate { get; set; }
        public uint? CopyPostId { get; set; }
        public uint Id { get; set; }
        public uint? ReplyPostId { get; set; }
        public uint? SignerId { get; set; }
        public User[] Profiles { get; set; }

        public VKApi Context { get; set; }
    }
}