using VKSharp.Core.Enums;

namespace VKSharp.Core.Entities {
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
                    return string.Format( "photo{0}_{1}", Photo.OwnerId, Photo.Id );
                case AttachmentType.PostedPhoto:
                    return string.Format( "photo{0}_{1}", PostedPhoto.OwnerId, PostedPhoto.Id );
                case AttachmentType.Video:
                    return string.Format( "video{0}_{1}", Video.OwnerId, Video.Id );
                case AttachmentType.Audio:
                    return string.Format( "audio{0}_{1}", Audio.OwnerId, Audio.Id );
                case AttachmentType.Doc:
                    return string.Format( "doc{0}_{1}", Audio.OwnerId, Audio.Id );
                case AttachmentType.Link:
                    return Link.Url;
            }
            return "Attached "+Type;
        }
    }
}
