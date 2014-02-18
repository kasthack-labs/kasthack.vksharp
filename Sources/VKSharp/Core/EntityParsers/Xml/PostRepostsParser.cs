using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostRepostsParser : IXmlVKEntityParser<PostReposts> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostReposts entity) {
            throw new NotImplementedException();
        }

        public PostReposts ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostReposts[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostReposts ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostReposts entity) {
            throw new NotImplementedException();
        }
    }
}
