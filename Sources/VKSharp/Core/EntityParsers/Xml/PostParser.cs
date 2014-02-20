using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostParser : IXmlVKEntityParser<Post> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Post entity) {
            throw new NotImplementedException();
        }

        public Post ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Post[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Post ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public bool UpdateFromFragment( XmlNode node, Post entity ) {
            throw new NotImplementedException();
        }
    }
}
