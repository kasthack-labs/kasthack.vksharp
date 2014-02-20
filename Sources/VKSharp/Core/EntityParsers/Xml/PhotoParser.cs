using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoParser : IXmlVKEntityParser<Photo> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Photo, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Photo, string>>>( ParserHelper.GetStringParsers<Photo> );

        private static Dictionary<string, Action<Photo, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Photo entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Photo ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Photo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Photo ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Photo();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, Photo entity ) {
            Action<Photo, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
