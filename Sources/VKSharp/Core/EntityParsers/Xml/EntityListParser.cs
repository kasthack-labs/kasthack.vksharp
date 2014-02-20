using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class EntityListParser<T> : IXmlVKEntityParser<EntityList<T>> where T : IVKEntity<T> {
        public IExecutor Executor { get; set; }

        public void FillFromXml(IEnumerable<XmlNode> nodes, EntityList<T> entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public EntityList<T> ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public EntityList<T> ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var el = new EntityList<T>();
            this.FillFromXml(nodes, el);
            return el;
            
        }

        public bool UpdateFromFragment(XmlNode node, EntityList<T> entity) {
            switch ( node.Name ) {
                case "count":
                    entity.TotalCount = uint.Parse( node.InnerText );
                    break;
                case "items":
                    entity.Items =  ( (SimpleXMLExecutor) this.Executor )
                        .GetParser<T>()
                        .ParseAllFromXml(node.ChildNodes.OfType<XmlNode>());
                    break;
                default:
                    return false;
            }
            return true;
        }

        public EntityList<T>[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
    }
}
