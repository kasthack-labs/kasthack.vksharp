﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Helpers.Parsers {
    public class PrimitiveParser<TP> : IVKEntityParser<StructEntity<TP>> where TP : struct {
        private readonly Func<string, TP> _parseFunc;
        public PrimitiveParser( Func<string, TP> parseFunc ) {
            this._parseFunc = parseFunc;
        }
        public void FillFromXml( IEnumerable<XmlNode> nodes, ref StructEntity<TP> entity ) {
            var n = nodes.Take( 1 ).ToArray();
            if ( n.Length > 0 )
                this.UpdateFromFragment( n[ 0 ], ref entity );
        }
        public StructEntity<TP> ParseFromXml( XmlNode node ) {
            var entity = new StructEntity<TP>();
            this.UpdateFromFragment( node, ref entity );
            return entity;
        }
        public StructEntity<TP>[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
        public StructEntity<TP> ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var entity = new StructEntity<TP>();
            this.FillFromXml( nodes, ref entity );
            return entity;
        }
        public void UpdateFromFragment( XmlNode node, ref StructEntity<TP> entity ) {
            entity.Data = this._parseFunc( node.InnerText.Trim() );
        }
    }
}