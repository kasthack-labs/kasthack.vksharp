using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PlaceParser : IXmlVKEntityParser<Place> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Place, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Place, string>>>( ParserHelper.GetStringParsers<Place> );

        private static Dictionary<string, Action<Place, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Place entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Place ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Place[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Place ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Place();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, Place entity ) {
            Action<Place, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
