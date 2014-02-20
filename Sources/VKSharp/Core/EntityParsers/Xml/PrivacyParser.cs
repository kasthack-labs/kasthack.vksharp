using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PrivacyParser : IXmlVKEntityParser<Privacy> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Privacy entity) {
            throw new NotImplementedException();
        }

        public Privacy ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Privacy[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Privacy ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public bool UpdateFromFragment( XmlNode node, Privacy entity ) {
            throw new NotImplementedException();
        }

    }
}
