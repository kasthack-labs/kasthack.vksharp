namespace kasthack.vksharp.DataTypes.Entities {
    public class Dialog {
        public Message Message { get; set; }
        public long Unread { get; set; }
        public long InRead { get; set; }
        public long OutRead { get; set; }
    }
}