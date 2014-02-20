using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostCommentsParser : IXmlVKEntityParser<PostComments> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<PostComments, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<PostComments, string>>>( ParserHelper.GetStringParsers<PostComments> );

        private static Dictionary<string, Action<PostComments, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, PostComments entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public PostComments ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public PostComments[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public PostComments ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new PostComments();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, PostComments entity ) {
            Action<PostComments, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
