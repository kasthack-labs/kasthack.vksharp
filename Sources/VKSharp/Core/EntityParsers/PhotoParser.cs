using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PhotoParser:IVKEntityParser<Photo> {
        private static readonly Lazy<PhotoParser> Lazy = new Lazy<PhotoParser>( () => new PhotoParser() );
        public static PhotoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PhotoParser() {}

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
