using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class CommentParser : IXmlVKEntityParser<Comment> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Comment, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Comment, string>>>( ParserHelper.GetStringParsers<Comment> );

        private static Dictionary<string, Action<Comment, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Comment entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Comment ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Comment[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Comment ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Comment();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, Comment entity) {
            Action<Comment, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}
