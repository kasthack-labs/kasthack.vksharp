using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class CommentLikesParser : IXmlVKEntityParser<CommentLikes> {
        public IExecutor Executor { get; set; }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref CommentLikes entity) {
            throw new NotImplementedException();
        }

        public CommentLikes ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public CommentLikes[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public CommentLikes ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref CommentLikes entity) {
            throw new NotImplementedException();
        }

    }
}
