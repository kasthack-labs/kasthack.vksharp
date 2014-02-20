using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class SiteProfilesParser : IXmlVKEntityParser<SiteProfiles> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<SiteProfiles, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<SiteProfiles, string>>>( ParserHelper.GetStringParsers<SiteProfiles> );

        private static Dictionary<string, Action<SiteProfiles, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, SiteProfiles entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public SiteProfiles ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public SiteProfiles[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public SiteProfiles ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var sc = new SiteProfiles();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, SiteProfiles entity ) {
            Action<SiteProfiles, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}
