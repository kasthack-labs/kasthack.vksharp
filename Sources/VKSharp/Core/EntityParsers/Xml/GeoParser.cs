using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class GeoParser : IXmlVKEntityParser<Geo> {
        public IExecutor Executor { get; set; }
        private static readonly Lazy<GeoParser> Lazy = new Lazy<GeoParser>( () => new GeoParser() );
        public static GeoParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private GeoParser() {}
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Geo entity) {
            throw new NotImplementedException();
        }

        public Geo ParseFromXml( XmlNode node ) {
            throw new NotImplementedException();
        }

        public Geo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Geo ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Geo entity) {
            throw new NotImplementedException();
        }
    }
}
