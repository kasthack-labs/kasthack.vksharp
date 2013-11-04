using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class GeoParser:IVKEntityParser<Geo> {
        private static readonly Lazy<GeoParser> Lazy = new Lazy<GeoParser>( () => new GeoParser() );
        public static GeoParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private GeoParser() {}
        public Geo ParseFromXml( XNode node ) {
            throw new NotImplementedException();
        }

        public Geo[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
