using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PlaceParser : IVKEntityParser<Place> {
        private static readonly Lazy<PlaceParser> Lazy = new Lazy<PlaceParser>( () => new PlaceParser() );
        public static PlaceParser Instanse {
            get { return Lazy.Value; }
        }

        private PlaceParser() {}

        public Place ParseFromXml( XNode node ) {
            throw new NotImplementedException();
        }

        public Place[] ParseAllFromXml( IEnumerable<XNode> nodes ) {
            throw new NotImplementedException();
        }
    }
}
