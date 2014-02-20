using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostParser : IXmlVKEntityParser<Post> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Post, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Post, string>>>( ParserHelper.GetStringParsers<Post> );

        private static Dictionary<string, Action<Post, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, Post entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Post ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Post[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Post ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Post();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, Post entity ) {
            Action<Post, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
