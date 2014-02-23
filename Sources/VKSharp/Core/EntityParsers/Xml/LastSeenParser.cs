using System.Xml.Linq;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityParsers.Xml {
    public class LastSeenParser:DefaultParser<LastSeen> {
        public override bool UpdateFromFragment( XElement node, LastSeen entity ) {
            if ( base.UpdateFromFragment( node, entity ) ) return true;
            if ( node.Name.ToString() != "platform" ) return false;
            entity.Platform = (VKPlatform) int.Parse( node.Value );
            return true;
        }
    }
}
