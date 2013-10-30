using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class PlaceParser : IVKEntityParser<Place> {
        private static readonly Lazy<PlaceParser> Lazy = new Lazy<PlaceParser>( () => new PlaceParser() );
        public static PlaceParser Instanse {
            get { return Lazy.Value; }
        }
        public Place ParseFromXml( XNode node ) {
            throw new NotImplementedException();
        }

        public Place[] ParseAllFromXml( IEnumerable<XNode> nodes ) {
            throw new NotImplementedException();
        }
    }
}
