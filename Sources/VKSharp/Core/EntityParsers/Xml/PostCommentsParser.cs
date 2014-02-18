using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostCommentsParser : IXmlVKEntityParser<PostComments> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostComments entity) {
            throw new NotImplementedException();
        }

        public PostComments ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostComments[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostComments ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostComments entity) {
            throw new NotImplementedException();
        }

    }
}
