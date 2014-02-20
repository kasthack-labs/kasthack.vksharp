using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class VideoParser : IXmlVKEntityParser<Video> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Video entity) {
            throw new NotImplementedException();
        }

        public Video ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Video[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Video ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public bool UpdateFromFragment(XmlNode node, Video entity) {
            throw new NotImplementedException();
        }
    }
}
