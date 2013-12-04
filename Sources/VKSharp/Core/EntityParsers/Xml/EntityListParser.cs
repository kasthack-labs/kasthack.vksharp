using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class EntityListParser<T>:IXmlVKEntityParser<EntityList<T>> where T : IVKEntity<T>, new() {
        private static readonly Lazy<EntityListParser<T>> Lazy = new Lazy<EntityListParser<T>>( () => new EntityListParser<T>() );
        public static EntityListParser<T> Instanse {
            get {
                return Lazy.Value;
            }
        }

        private EntityListParser() { }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref EntityList<T> entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, ref entity );
        }

        public EntityList<T> ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public EntityList<T> ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var el = new EntityList<T>();
            this.FillFromXml(nodes, ref el);
            return el;
            
        }

        public void UpdateFromFragment(XmlNode node, ref EntityList<T> entity) {
            switch ( node.Name ) {
                case "count":
                    entity.TotalCount = uint.Parse( node.InnerText );
                    break;
                case "items":
                    entity.Items = new T().GetParser().ParseAllFromXml(node.ChildNodes.OfType<XmlNode>());
                    break;
            }
        }

        public EntityList<T>[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
    }
}
