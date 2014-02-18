using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostSourceParser : IXmlVKEntityParser<PostSource> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostSource entity) {
            throw new NotImplementedException();
        }

        public PostSource ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public PostSource[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            throw new NotImplementedException();
        }

        public PostSource ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostSource entity) {
            throw new NotImplementedException();
        }
    }
}
