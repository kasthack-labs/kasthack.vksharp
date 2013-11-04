using VKSharp.Core.EntityParsers;
using VKSharp.Core.Enums;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class Attachment:IVKEntity<Attachment> {
        public AttachmentType Type { get; set; }
        public object AttachmentBody { get; set; }

        public IVKEntityParser<Attachment> GetParser() {
            return AttachmentParser.Instanse;
        }
    }
}
