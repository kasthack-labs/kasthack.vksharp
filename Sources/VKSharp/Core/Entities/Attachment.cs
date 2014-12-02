using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Attachment:IVKEntity<Attachment> {
        public AttachmentType? Type { get; set; }
        public object AttachmentBody { get; set; }
        
    }
}
