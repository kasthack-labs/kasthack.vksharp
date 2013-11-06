using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Comment : IVKEntity<Comment> {

        public Attachment[] Attachments { get; set; }
        public CommentLikes Likes { get; set; }
        public int FromID { get; set; }
        public int ReplyToID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }
        public uint Date { get; set; }
        public uint ID { get; set; }
        public uint ReplyToCID { get; set; }

        public IVKEntityParser<Comment> GetParser() {
            return CommentParser.Instanse;
        }
    }
}
