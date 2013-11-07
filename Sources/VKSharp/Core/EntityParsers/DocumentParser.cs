using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class DocumentParser : IVKEntityParser<Document> {
        private static readonly Lazy<DocumentParser> Lazy = new Lazy<DocumentParser>( () => new DocumentParser() );
        public static DocumentParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private DocumentParser() { }
        public Document ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Document[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
