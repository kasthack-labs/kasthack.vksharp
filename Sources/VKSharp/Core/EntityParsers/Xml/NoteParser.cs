using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class NoteParser : IXmlVKEntityParser<Note> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Note, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Note, string>>>( ParserHelper.GetStringParsers<Note> );

        private static Dictionary<string, Action<Note, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, Note entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Note ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Note[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Note ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new Note();
            this.FillFromXml( nodes, sc );
            return sc;
        }
        public bool UpdateFromFragment( XmlNode node, Note entity ) {
            Action<Note, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
