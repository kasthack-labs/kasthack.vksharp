using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class DocumentParser : IVKEntityParser<Document> {
        private static readonly Lazy<DocumentParser> Lazy = new Lazy<DocumentParser>( () => new DocumentParser() );
        public static DocumentParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        public Document ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Document[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
