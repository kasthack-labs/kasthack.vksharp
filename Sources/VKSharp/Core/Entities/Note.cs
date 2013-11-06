using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Note : OwnedEntity<Note> {
        //UserID -> OwnerID
        public override int OwnerID { get; set; }
        public uint Date { get; set; }
        public uint CommentCount { get; set; }
        public uint? ReadCommentCount { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public override IVKEntityParser<Note> GetParser() {
            return NoteParser.Instanse;
        }
    }
}
