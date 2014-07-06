using System.Xml.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PrivacyParser : DefaultParser<Privacy> {
        public override bool UpdateFromFragment( XElement node, Privacy entity ) {
            return base.UpdateFromFragment( node, entity );
        }
    }
}
