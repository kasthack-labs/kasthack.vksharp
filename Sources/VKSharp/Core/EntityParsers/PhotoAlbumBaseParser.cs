using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PhotoAlbumBaseParser : IVKEntityParser<PhotoAlbumBase> {
        private static readonly Lazy<PhotoAlbumBaseParser> Lazy = new Lazy<PhotoAlbumBaseParser>( () => new PhotoAlbumBaseParser() );
        public static PhotoAlbumBaseParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private PhotoAlbumBaseParser() { }
        public PhotoAlbumBase ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PhotoAlbumBase[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
