using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Post : OwnedEntity<Post> {
        public uint Id { get; set; }
        public int OwnerId { get; set; }
        public int FromId { get; set; }
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

        public VKApi Context { get; set; }

        public override string ToString () {
            return string.Format( "Post #{0}@{1}by{2}", Id, OwnerId, FromId );
        }
    }
}