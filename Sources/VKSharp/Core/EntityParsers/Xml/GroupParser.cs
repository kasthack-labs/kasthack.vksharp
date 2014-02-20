using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class GroupParser : IXmlVKEntityParser<Group> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Group, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Group, string>>>( ParserHelper.GetStringParsers<Group> );

        private static Dictionary<string, Action<Group, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, Group entity ) {
            foreach (var cn in nodes)
                this.UpdateFromFragment( cn, entity );
        }

        public Group ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Group[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Group ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var sc = new Group();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, Group entity ) {
            Action<Group, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
