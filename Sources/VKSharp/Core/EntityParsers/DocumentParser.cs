using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class DocumentParser : IVKEntityParser<Document> {
        private static readonly Lazy<DocumentParser> Lazy = new Lazy<DocumentParser>( () => new DocumentParser() );
        public static DocumentParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private DocumentParser() { }
        public Document ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Document[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
