using System.Xml.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoParser : DefaultParser<Photo> {
        public override bool UpdateFromFragment( XElement node, Photo entity ) {
            if ( base.UpdateFromFragment( node, entity ) )
                return true;
            var updated = true;
            switch ( node.Name.LocalName.ToLowerInvariant() ) {
                case "likes":
                    entity.Likes = GetP<PhotoLikes>().ParseFromXml( node );
                    break;
                case "tags":
                    entity.Tags = GetP<Counter>().ParseFromXml( node );
                    break;
                case "comments":
                    entity.Comments = GetP<Counter>().ParseFromXml( node );
                    break;
                default:
                    updated = false;
                    break;
            }
            return updated;
        }
    }
}
