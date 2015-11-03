using System;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Message {
        public int UserId { get; set; }
        public int Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public MessageReadState? ReadState { get; set; }
        public MessageType? Type { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Out { get; set; }
        public Attachment[] Attachments { get; set; }
        public Message[] ForwardedMessages { get; set; }
        public bool ContainsEmojiSmiles { get; set; }
        public bool IsImportant { get; set; }
        public bool? IsDeleted { get; set; }
        public int Unread { get; set; }
        public long? ChatId { get; set; }
        public int[] ChatActiveIds { get; set; }
        public int? UsersCount { get; set; }
        public long? AdminId { get; set; }
        public ProfilePhotos PhotoPreviews { get; set; }
        public override string ToString() => $"User:{UserId}/Message:{Id} wrote: {Body}";
    }
}
