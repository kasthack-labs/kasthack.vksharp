using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class SchoolParser : IXmlVKEntityParser<School> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<School, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<School, string>>>( ParserHelper.GetStringParsers<School> );

        private static Dictionary<string, Action<School, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, School entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public School ParseFromXml( XmlNode node ) {
            if ( String.CompareOrdinal( node.Name, "school" ) != 0 )
                return null;
            return this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public School[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public School ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new School();
            this.FillFromXml(nodes, sc);
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, School entity ) {
            Action<School, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}
