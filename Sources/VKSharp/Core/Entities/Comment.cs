using VKSharp.Core.EntityFragments;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Comment : IVKEntity<Comment> {
        public long Id{ get; set; }
        public int FromId{ get; set; }
        public uint Date { get; set; }
        public string Text { get; set; }
        public int ReplyToUser{ get; set; }
        public long ReplyToComment { get; set; }
        public Attachment[] Attachments { get; set; }
        public CommentLikes Likes { get; set; }
    }
}
