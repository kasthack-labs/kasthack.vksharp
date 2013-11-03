using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Xml.Linq;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class AttachmentParser:IVKEntityParser<Attachment> {
        private static readonly Lazy<AttachmentParser> Lazy = new Lazy<AttachmentParser>( () => new AttachmentParser() );
        public static AttachmentParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private AttachmentParser() { }
        public Attachment ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Attachment[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
