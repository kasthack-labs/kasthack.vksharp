using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class GeoParser : IXmlVKEntityParser<Geo> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Geo, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Geo, string>>>( ParserHelper.GetStringParsers<Geo> );

        private static Dictionary<string, Action<Geo, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Geo entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Geo ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Geo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Geo ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Geo();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, Geo entity) {
            Action<Geo, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
