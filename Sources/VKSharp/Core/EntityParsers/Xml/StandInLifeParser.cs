using System;
using VKSharp.Core.EntityFragments;
using VKSharp.Helpers.PrimitiveEntities;
using System.Linq;
namespace VKSharp.Core.EntityParsers.Xml {
    public class StandInLifeParser:DefaultParser<StandInLife> {
        public override bool UpdateFromFragment (System.Xml.Linq.XElement node, StandInLife entity) {
            if ( node.Name != "langs" )
                return base.UpdateFromFragment( node, entity );
            else
                entity.Langs = this.GetP<SimpleEntity<String>>()
                    .ParseAllFromXml( node.Elements() )
                    .Select( a => a.Data )
                    .ToArray();
            return true;
        }
    }
}