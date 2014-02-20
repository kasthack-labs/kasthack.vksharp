using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class GraffityParser : IXmlVKEntityParser<Graffity> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Graffity, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Graffity, string>>>( ParserHelper.GetStringParsers<Graffity> );

        private static Dictionary<string, Action<Graffity, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, Graffity entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Graffity ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Graffity[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Graffity ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Graffity();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, Graffity entity) {
            Action<Graffity, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
