using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class DocumentParser : IXmlVKEntityParser<Document> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Document, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Document, string>>>( ParserHelper.GetStringParsers<Document> );

        private static Dictionary<string, Action<Document, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Document entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Document ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Document[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Document ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Document();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, Document entity) {
            Action<Document, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}
