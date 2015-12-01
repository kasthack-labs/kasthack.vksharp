using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Attachment  {
        public ContentType? Type { get; set; }
        public Photo Photo { get; set; }
        public PostedPhoto PostedPhoto { get; set; }
        public Video Video { get; set; }
        public Audio Audio { get; set; }
        public Graffity Graffity { get; set; }
        public Document Doc { get; set; }
        public Link Link { get; set; }
        public Note Note { get; set; }
        public Comment WallReply { get; set; }
        public Poll Poll { get; set; }
        public Page Page { get; set; }
        public PhotoAlbum Album { get; set; }
        public Post Wall { get; set; }

        public override string ToString() {
            switch ( Type ) {
                case ContentType.Photo:
                    return ((ContentId)Photo).ToAttachmentString();
                case ContentType.PostedPhoto:
                    return ((ContentId)PostedPhoto).ToAttachmentString();
                case ContentType.Video:
                    return ((ContentId)Video).ToAttachmentString();
                case ContentType.Audio:
                    return ((ContentId)Audio).ToAttachmentString();
                case ContentType.Doc:
                    return ((ContentId)Doc).ToAttachmentString();
                case ContentType.Link:
                    return ((ContentId)Link).ToAttachmentString();
                //case AttachmentType.Graffiti:
                //break;
                case ContentType.Note:
                    return ((ContentId)Note).ToAttachmentString();
                //case AttachmentType.App:
                //    break;
                case ContentType.Poll:
                    return ((ContentId)Poll).ToAttachmentString();
                case ContentType.Page:
                    return ((ContentId)Page).ToAttachmentString();
                case ContentType.Album:
                    return ((ContentId)Album).ToAttachmentString();
                //case AttachmentType.PhotosList:
                //break;
                case ContentType.Wall:
                    return ((ContentId)Wall).ToAttachmentString();
                case ContentType.WallReply:
                    return ((ContentId) WallReply).ToAttachmentString();
                //case null:
                //break;
                default:
                    return $"Attached {Type}";
            }
        }
    }
}
