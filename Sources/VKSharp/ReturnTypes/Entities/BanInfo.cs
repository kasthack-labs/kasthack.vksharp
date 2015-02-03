namespace VKSharp.Core.Entities {
    public class BanInfo {
        public int AdminId{ get; set; }
        public int Date { get; set; }
        public int EndDate { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }
        public bool CommentVisible { get; set; }
    }
}
