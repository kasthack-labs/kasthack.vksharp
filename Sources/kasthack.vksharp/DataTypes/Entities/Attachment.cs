using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Attachment  {
        public AttachmentType? Type { get; set; }
        public Photo Photo { get; set; }
        public PostedPhoto PostedPhoto { get; set; }
        public Video Video { get; set; }
        public Audio Audio { get; set; }
        public Graffity Graffity { get; set; }
        public Document Doc { get; set; }
        public Link Link { get; set; }
        public Note Note { get; set; }
        //todo:app
        public Poll Poll { get; set; }
        //todo:wikipage
        public PhotoAlbum Album { get; set; }


        public override string ToString() {
            switch ( Type ) {
                case AttachmentType.Photo:
                    return $"photo{Photo.OwnerId}_{Photo.Id}";
                case AttachmentType.PostedPhoto:
                    return $"photo{PostedPhoto.OwnerId}_{PostedPhoto.Id}";
                case AttachmentType.Video:
                    return $"video{Video.OwnerId}_{Video.Id}";
                case AttachmentType.Audio:
                    return $"audio{Audio.OwnerId}_{Audio.Id}";
                case AttachmentType.Doc:
                    return $"doc{Doc.OwnerId}_{Doc.Id}";
                case AttachmentType.Link:
                    return Link.Url;
                //case AttachmentType.Graffiti:
                    //break;
                case AttachmentType.Note:
                    return $"note{Note.OwnerId}_{Note.Id}";
                //case AttachmentType.App:
                //    break;
                case AttachmentType.Poll:
                    return $"poll{Poll.OwnerId}_{Poll.Id}";
                //case AttachmentType.Page:
                //    break;
                case AttachmentType.Album:
                    return $"album{Album.OwnerId}_{Album.Id}";
                //case AttachmentType.PhotosList:
                    //break;
                //case AttachmentType.Wall:
                    //return $"wall{Album.OwnerId}_{Album.Id}";
                //case AttachmentType.WallReply:
                    //break;
                //case null:
                    //break;
                default:
                    return $"Attached {Type}";
            }
        }
    }
}
