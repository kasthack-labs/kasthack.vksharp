using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class NoteParser : IXmlVKEntityParser<Note> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Note entity) {
            throw new NotImplementedException();
        }

        public Note ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Note[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Note ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
        public bool UpdateFromFragment( XmlNode node, Note entity ) {
            throw new NotImplementedException();
        }
    }
}
