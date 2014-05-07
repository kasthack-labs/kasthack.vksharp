using System;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityParsers.Xml {
    public class LinkCheckResultParser : DefaultParser<LinkCheckResult> {
        public override bool UpdateFromFragment( XElement node,
                                                 LinkCheckResult entity ) {
            if ( base.UpdateFromFragment( node, entity ) )
                return true;
            if ( node.Name != "status" )
                return false;
            entity.Status = (LinkCheckStatus) Enum.Parse( typeof( LinkCheckStatus ), node.Value );
            return true;
        }
    }
}
