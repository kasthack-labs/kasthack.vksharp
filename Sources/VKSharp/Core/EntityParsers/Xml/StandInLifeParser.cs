using System;
using System.Xml.Linq;
using VKSharp.Core.EntityFragments;
using VKSharp.Helpers.PrimitiveEntities;
using System.Linq;
namespace VKSharp.Core.EntityParsers.Xml {
    public class StandInLifeParser:DefaultParser<StandInLife> {
        public override bool UpdateFromFragment (XElement node, StandInLife entity) {
            if ( node.Name != "langs" )
                return base.UpdateFromFragment( node, entity );
            entity.Langs = GetP<SimpleEntity<String>>()
                .ParseAllFromXml( node.Elements() )
                .Select( a => a.Data )
                .ToArray();
            return true;
        }
    }
}