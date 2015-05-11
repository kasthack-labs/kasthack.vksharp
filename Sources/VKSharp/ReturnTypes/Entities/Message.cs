using System;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Message : OwnedEntity<Message> {
        public DateTime? Date { get; set; }
        public MessageReadState? ReadState { get; set; }
        public MessageType? Type { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
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
    }
}
