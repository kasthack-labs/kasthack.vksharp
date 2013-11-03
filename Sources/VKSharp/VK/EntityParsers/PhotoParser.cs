using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class PhotoParser:IVKEntityParser<Photo> {
        private static readonly Lazy<PhotoParser> Lazy = new Lazy<PhotoParser>( () => new PhotoParser() );
        public static PhotoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PhotoParser() {}

        public Photo ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Photo[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
