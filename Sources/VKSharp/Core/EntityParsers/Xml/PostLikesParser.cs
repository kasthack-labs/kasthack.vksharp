using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostLikesParser : IXmlVKEntityParser<PostLikes> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<PostLikes, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<PostLikes, string>>>( ParserHelper.GetStringParsers<PostLikes> );

        private static Dictionary<string, Action<PostLikes, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, PostLikes entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public PostLikes ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public PostLikes[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public PostLikes ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new PostLikes();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, PostLikes entity ) {
            Action<PostLikes, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
