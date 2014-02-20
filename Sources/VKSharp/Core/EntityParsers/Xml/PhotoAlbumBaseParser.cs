using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoAlbumBaseParser : IXmlVKEntityParser<PhotoAlbumBase> {
        public IExecutor Executor { get; set; }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, PhotoAlbumBase entity) {
            throw new NotImplementedException();
        }

        public PhotoAlbumBase ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PhotoAlbumBase[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PhotoAlbumBase ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
        public bool UpdateFromFragment( XmlNode node, PhotoAlbumBase entity ) {
            throw new NotImplementedException();
        }
    }
}
