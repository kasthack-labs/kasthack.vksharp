using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Comment : IVKEntity<Comment> {
        public uint Date { get; set; }
        public uint ID { get; set; }
        public uint ReplyToCID { get; set; }
        public int ReplyToID { get; set; }
        public int UserID { get; set; }
        public int FromID { get; set; }
        public string Text { get; set; }
        public Attachment[] Attachments { get; set; }
        public CommentLikes Likes { get; set; }
        public IVKEntityParser<Comment> GetParser() {
            return CommentParser.Instanse;
        }
    }
}
