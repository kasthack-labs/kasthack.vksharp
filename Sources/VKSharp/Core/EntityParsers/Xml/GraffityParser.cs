using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class GraffityParser:IXmlVKEntityParser<Graffity> {
        private static readonly Lazy<GraffityParser> Lazy = new Lazy<GraffityParser>( () => new GraffityParser() );
        public static GraffityParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private GraffityParser() { }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Graffity entity) {
            throw new NotImplementedException();
        }

        public Graffity ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Graffity[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Graffity ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Graffity entity) {
            throw new NotImplementedException();
        }
    }
}
