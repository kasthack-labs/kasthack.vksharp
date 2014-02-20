using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostSourceParser : IXmlVKEntityParser<PostSource> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<PostSource, string>>> _generatedParsers =
    new Lazy<Dictionary<string, Action<PostSource, string>>>( ParserHelper.GetStringParsers<PostSource> );

        private static Dictionary<string, Action<PostSource, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, PostSource entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public PostSource ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public PostSource[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public PostSource ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var sc = new PostSource();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, PostSource entity ) {
            Action<PostSource, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
