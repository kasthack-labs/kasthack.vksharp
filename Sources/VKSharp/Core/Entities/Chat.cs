namespace VKSharp.Core.Entities {
    public class Chat {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public long? AdminId { get; set; }
        public int[] Users { get; set; }
    }
}
