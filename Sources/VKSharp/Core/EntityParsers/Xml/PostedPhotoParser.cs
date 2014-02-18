using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostedPhotoParser : IXmlVKEntityParser<PostedPhoto> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostedPhoto entity) {
            throw new NotImplementedException();
        }

        public PostedPhoto ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostedPhoto[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostedPhoto ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostedPhoto entity) {
            throw new NotImplementedException();
        }

    }
}