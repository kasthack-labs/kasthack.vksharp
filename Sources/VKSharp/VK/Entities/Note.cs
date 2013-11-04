using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Note:IVKEntity<Note> {
        public uint ID { get; set; }
        public uint UserID { get; set; }
        public uint Date { get; set; }
        public uint CommentCount { get; set; }
        public uint? ReadCommentCount { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public IVKEntityParser<Note> GetParser() {
            return NoteParser.Instanse;
        }
    }
}
