using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class GeoParser:IVKEntityParser<Geo> {
        private static readonly Lazy<GeoParser> Lazy = new Lazy<GeoParser>( () => new GeoParser() );
        public static GeoParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private GeoParser() {}
        public Geo ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public Geo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
