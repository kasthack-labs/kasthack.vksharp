using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class ProfileCountersParser : IXmlVKEntityParser<ProfileCounters> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<ProfileCounters, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<ProfileCounters, string>>>( ParserHelper.GetStringParsers<ProfileCounters> );

        private static Dictionary<string, Action<ProfileCounters, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, ProfileCounters entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public ProfileCounters ParseFromXml( XmlNode node ) {
            return String.CompareOrdinal( node.Name, "counters" ) != 0 ? null : this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public ProfileCounters[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where(a=>a!=null).ToArray();
        }

        public ProfileCounters ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var pc = new ProfileCounters();
            this.FillFromXml(nodes, pc);
            return pc;
        }

        public bool UpdateFromFragment(XmlNode node, ProfileCounters entity) {
            Action<ProfileCounters, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}