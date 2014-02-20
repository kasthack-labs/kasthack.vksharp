using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PlaceParser : IXmlVKEntityParser<Place> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Place entity) {
            throw new NotImplementedException();
        }

        public Place ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public Place[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            throw new NotImplementedException();
        }

        public Place ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public bool UpdateFromFragment( XmlNode node, Place entity ) {
            throw new NotImplementedException();
        }
    }
}
