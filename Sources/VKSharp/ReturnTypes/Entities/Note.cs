using System;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Note : OwnedEntity {
        //UserId -> OwnerId
        public int UserId { get { return OwnerId; } set { OwnerId = value; } }
        public DateTimeOffset Date { get; set; }
        public int CommentCount { get; set; }
        public int? ReadCommentCount { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
    }
}
