using VKSharp.VK.EntityParsers;
using VKSharp.VK.Helpers.DataTypes;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Attachment:IVKEntity<Attachment> {
        public AttachmentType Type { get; set; }
        public object AttachmentBody { get; set; }

        public IVKEntityParser<Attachment> GetParser() {
            return AttachmentParser.Instanse;
        }
    }
}
