using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class CommentLikesParser : IXmlVKEntityParser<CommentLikes> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<CommentLikes, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<CommentLikes, string>>>( ParserHelper.GetStringParsers<CommentLikes> );

        private static Dictionary<string, Action<CommentLikes, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, CommentLikes entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public CommentLikes ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public CommentLikes[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public CommentLikes ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new CommentLikes();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, CommentLikes entity) {
            Action<CommentLikes, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}
