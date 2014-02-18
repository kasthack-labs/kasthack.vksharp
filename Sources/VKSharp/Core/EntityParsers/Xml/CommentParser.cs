using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class CommentParser : IXmlVKEntityParser<Comment> {
        public IExecutor Executor { get; set; }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, Comment entity) {
            throw new NotImplementedException();
        }

        public Comment ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Comment[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Comment ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, Comment entity) {
            throw new NotImplementedException();
        }

    }
}
