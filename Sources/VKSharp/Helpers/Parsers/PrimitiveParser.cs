using System;
using System.Xml.Linq;
using VKSharp.Core.EntityParsers.Xml;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Helpers.Parsers {
    public class PrimitiveParser<TP> : DefaultParser<StructEntity<TP>> where TP : struct {
        private readonly Func<string, TP> _parseFunc;
        public PrimitiveParser( Func<string, TP> parseFunc ) {
            this._parseFunc = parseFunc;
        }
        public override bool UpdateFromFragment( XElement node, StructEntity<TP> entity ) {
            entity.Data = this._parseFunc( node.Value.Trim() );
            return true;
        }
    }
}