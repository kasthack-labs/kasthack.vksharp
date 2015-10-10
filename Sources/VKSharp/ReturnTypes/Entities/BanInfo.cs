using System;

namespace VKSharp.Core.Entities {
    public class BanInfo {
        public int AdminId{ get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }
        public bool CommentVisible { get; set; }
    }
}
