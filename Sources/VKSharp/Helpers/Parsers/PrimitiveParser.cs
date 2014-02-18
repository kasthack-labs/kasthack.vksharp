using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Helpers.Parsers {
    public class PrimitiveParser<TP> : IXmlVKEntityParser<StructEntity<TP>> where TP : struct {
        private readonly Func<string, TP> _parseFunc;
        public IExecutor Executor { get; set; }
        public PrimitiveParser( Func<string, TP> parseFunc ) {
            this._parseFunc = parseFunc;
        }
        public void FillFromXml( IEnumerable<XmlNode> nodes, StructEntity<TP> entity ) {
            var n = nodes.Take( 1 ).ToArray();
            if ( n.Length > 0 )
                this.UpdateFromFragment( n[ 0 ], entity );
        }
        public StructEntity<TP> ParseFromXml( XmlNode node ) {
            var entity = new StructEntity<TP>();
            this.UpdateFromFragment( node, entity );
            return entity;
        }
        public StructEntity<TP>[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
        public StructEntity<TP> ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var entity = new StructEntity<TP>();
            this.FillFromXml( nodes, entity );
            return entity;
        }
        public void UpdateFromFragment( XmlNode node, StructEntity<TP> entity ) {
            entity.Data = this._parseFunc( node.InnerText.Trim() );
        }
    }
}