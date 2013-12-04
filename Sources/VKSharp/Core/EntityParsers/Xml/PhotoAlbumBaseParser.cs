using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PhotoAlbumBaseParser : IXmlVKEntityParser<PhotoAlbumBase> {
        private static readonly Lazy<PhotoAlbumBaseParser> Lazy = new Lazy<PhotoAlbumBaseParser>( () => new PhotoAlbumBaseParser() );
        public static PhotoAlbumBaseParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private PhotoAlbumBaseParser() { }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PhotoAlbumBase entity) {
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
        public void UpdateFromFragment(XmlNode node, ref PhotoAlbumBase entity) {
            throw new NotImplementedException();
        }
    }
}
