using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Attachment : IVKEntity<Attachment> {
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
    }
}
