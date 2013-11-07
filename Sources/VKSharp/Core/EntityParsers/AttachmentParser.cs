using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class AttachmentParser : IVKEntityParser<Attachment> {
        private static readonly Lazy<AttachmentParser> Lazy = new Lazy<AttachmentParser>( () => new AttachmentParser() );
        public static AttachmentParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private AttachmentParser() { }
        public Attachment ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public Attachment[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            throw new NotImplementedException();
        }
    }
}
