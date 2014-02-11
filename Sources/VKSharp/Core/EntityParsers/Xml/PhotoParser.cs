using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoParser : IXmlVKEntityParser<Photo> {
        public IExecutor Executor { get; set; }
        private static readonly Lazy<PhotoParser> Lazy = new Lazy<PhotoParser>( () => new PhotoParser() );
        public static PhotoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PhotoParser() {}

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Photo entity) {
            throw new NotImplementedException();
        }

        public Photo ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Photo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Photo ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Photo entity) {
            throw new NotImplementedException();
        }
    }
}
