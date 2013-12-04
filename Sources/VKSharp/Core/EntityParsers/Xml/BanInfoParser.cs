using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class BanInfoParser:IXmlVKEntityParser<BanInfo> {

        private static readonly Lazy<BanInfoParser> Lazy = new Lazy<BanInfoParser>( () => new BanInfoParser() );
        public static BanInfoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private BanInfoParser() { }
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref BanInfo entity) {
            foreach ( var node in nodes )
                this.UpdateFromFragment( node, ref entity );
        }

        public BanInfo ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public BanInfo[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select(this.ParseFromXml).ToArray();
        }

        public BanInfo ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var entity = new BanInfo();
            this.FillFromXml(nodes, ref entity);
            return entity;
        }

        public void UpdateFromFragment(XmlNode node, ref BanInfo entity) {
            switch ( node.Name ) {
                case"admin_id":
                    entity.AdminID = uint.Parse(node.InnerText);
                    break;
                case "date":
                    entity.AddDate = uint.Parse( node.InnerText );
                    break;
                case "end_date":
                    entity.EndDate = uint.Parse( node.InnerText );
                    break;
                case "reason":
                    entity.Reason = node.InnerText;
                    break;
                case "comment":
                    entity.Comment = node.InnerText;
                    break;
            }
        }
    }
}
