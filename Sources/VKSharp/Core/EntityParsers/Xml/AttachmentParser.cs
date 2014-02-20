using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AttachmentParser : IXmlVKEntityParser<Attachment> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Attachment, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Attachment, string>>>( ParserHelper.GetStringParsers<Attachment> );

        private static Dictionary<string, Action<Attachment, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Attachment entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Attachment ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Attachment[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Attachment ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Attachment();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, Attachment entity) {
            Action<Attachment, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
