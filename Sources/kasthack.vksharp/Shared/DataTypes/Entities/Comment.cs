using System;
using kasthack.vksharp.DataTypes.EntityFragments;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Comment : OwnedEntity {
        public int PostId { get; set; }
        public int FromId{ get; set; }

        public DateTimeOffset Date { get; set; }
        public string Text { get; set; }
        public Attachment[] Attachments { get; set; }
        public CommentLikes Likes { get; set; }
        public int ReplyToUser { get; set; }
        public long ReplyToComment { get; set; }

        public static implicit operator ObjectContentId(Comment comment)=>new ObjectContentId( ContentType.WallReply, comment.Id, comment.OwnerId );

        public static implicit operator ContentId( Comment comment ) => (ObjectContentId) comment;

    }
}
