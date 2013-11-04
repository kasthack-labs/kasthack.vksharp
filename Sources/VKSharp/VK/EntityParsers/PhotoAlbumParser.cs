using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class PhotoAlbumParser : IVKEntityParser<PhotoAlbum> {
        private static readonly Lazy<PhotoAlbumParser> Lazy = new Lazy<PhotoAlbumParser>( () => new PhotoAlbumParser() );
        public static PhotoAlbumParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PhotoAlbumParser() { }
        public PhotoAlbum ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public PhotoAlbum[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
