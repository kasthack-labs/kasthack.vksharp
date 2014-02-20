using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UniversityParser : IXmlVKEntityParser<University> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<University, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<University, string>>>( ParserHelper.GetStringParsers<University> );

        private static Dictionary<string, Action<University, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, University entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public University ParseFromXml(XmlNode node) {
            return String.CompareOrdinal(node.Name, "university") != 0 ? null : this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public University[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where(a=>a!=null).ToArray();
        }

        public University ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new University();
            this.FillFromXml(nodes, sc);
            return sc;
        }

        public bool UpdateFromFragment(XmlNode node, University entity) {
            Action<University, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
