using System;
using System.Xml.Linq;
using VKSharp.Core.EntityParsers.Xml;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Helpers.Parsers {
    public class PrimitiveParser<TP> : DefaultParser<StructEntity<TP>> where TP : struct {
        private readonly Func<string, TP> _parseFunc;
        public PrimitiveParser( Func<string, TP> parseFunc ) {
            _parseFunc = parseFunc;
        }
        public override bool UpdateFromFragment( XElement node, StructEntity<TP> entity ) {
            entity.Data = _parseFunc( node.Value.Trim() );
            return true;
        }
    }
}