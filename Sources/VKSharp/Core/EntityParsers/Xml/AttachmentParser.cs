using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AttachmentParser : IXmlVKEntityParser<Attachment> {
        public IExecutor Executor { get; set; }
        private static readonly Lazy<AttachmentParser> Lazy = new Lazy<AttachmentParser>( () => new AttachmentParser() );
        public static AttachmentParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private AttachmentParser() { }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Attachment entity) {
            throw new NotImplementedException();
        }

        public Attachment ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public Attachment[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            throw new NotImplementedException();
        }

        public Attachment ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Attachment entity) {
            throw new NotImplementedException();
        }

    }
}
