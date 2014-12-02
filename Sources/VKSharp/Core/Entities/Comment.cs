using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Comment : IVKEntity<Comment> {
        
        public Attachment[] Attachments { get; set; }
        public CommentLikes Likes { get; set; }
        public int FromId{ get; set; }
        public int ReplyToId{ get; set; }
        public int UserId{ get; set; }
        public string Text { get; set; }
        public uint Date { get; set; }
        public uint Id{ get; set; }
        public uint ReplyToCId{ get; set; }

        
    }
}
