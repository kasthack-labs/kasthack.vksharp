using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Note : OwnedEntity<Note> {
        //UserId -> OwnerId
        public int Date { get; set; }
        public int CommentCount { get; set; }
        public int? ReadCommentCount { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
    }
}
