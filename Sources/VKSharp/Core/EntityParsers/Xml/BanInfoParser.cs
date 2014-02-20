using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class BanInfoParser : IXmlVKEntityParser<BanInfo> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<BanInfo, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<BanInfo, string>>>( ParserHelper.GetStringParsers<BanInfo> );

        private static Dictionary<string, Action<BanInfo, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, BanInfo entity) {
            foreach ( var node in nodes )
                this.UpdateFromFragment( node, entity );
        }

        public BanInfo ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public BanInfo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select(this.ParseFromXml).ToArray();
        }

        public BanInfo ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var entity = new BanInfo();
            this.FillFromXml(nodes, entity);
            return entity;
        }

        public bool UpdateFromFragment(XmlNode node, BanInfo entity) {
            Action<BanInfo, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
