using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PlaceParser : IVKEntityParser<Place> {
        private static readonly Lazy<PlaceParser> Lazy = new Lazy<PlaceParser>( () => new PlaceParser() );
        public static PlaceParser Instanse {
            get { return Lazy.Value; }
        }

        private PlaceParser() {}

        public Place ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public Place[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            throw new NotImplementedException();
        }

        public Place ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Place entity) {
            throw new NotImplementedException();
        }
    }
}
