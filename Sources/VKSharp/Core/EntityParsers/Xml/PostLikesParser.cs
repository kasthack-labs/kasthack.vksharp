using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostLikesParser : IXmlVKEntityParser<PostLikes> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, PostLikes entity) {
            throw new NotImplementedException();
        }

        public PostLikes ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostLikes[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostLikes ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, PostLikes entity) {
            throw new NotImplementedException();
        }
    }
}
