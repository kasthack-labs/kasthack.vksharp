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

        public override string ToString () {
            return string.Format ("[Post: Attachments={0}, FriendsOnly={1}, Geo={2}, Groups={3}, CopyOwnerId={4}, FromId={5}, ReplyOwnerId={6}, ToId={7}, CopyHistory={8}, Comments={9}, PostLikes={10}, PostSource={11}, Reposts={12}, CopyPostType={13}, PostType={14}, CopyText={15}, Text={16}, Date={17}, CopyPostDate={18}, CopyPostId={19}, Id={20}, ReplyPostId={21}, SignerId={22}, Profiles={23}, Context={24}]", Attachments, FriendsOnly, Geo, Groups, CopyOwnerId, FromId, ReplyOwnerId, ToId, CopyHistory, Comments, PostLikes, PostSource, Reposts, CopyPostType, PostType, CopyText, Text, Date, CopyPostDate, CopyPostId, Id, ReplyPostId, SignerId, Profiles, Context);
        }
    }
}