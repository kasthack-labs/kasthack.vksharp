using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostRepostsParser : IXmlVKEntityParser<PostReposts> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<PostReposts, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<PostReposts, string>>>( ParserHelper.GetStringParsers<PostReposts> );

        private static Dictionary<string, Action<PostReposts, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, PostReposts entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public PostReposts ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public PostReposts[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public PostReposts ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new PostReposts();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, PostReposts entity ) {
            Action<PostReposts, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
