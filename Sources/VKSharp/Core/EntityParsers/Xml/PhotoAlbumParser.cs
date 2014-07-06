using System.Xml.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoAlbumParser : DefaultParser<PhotoAlbum> {
        public override bool UpdateFromFragment( XElement node, PhotoAlbum entity ) {
            if ( base.UpdateFromFragment( node, entity ) )
                return true;
            switch ( node.Name.ToString().ToLowerInvariant() ) {
                case "privacy_view":
                    entity.PrivacyView = this.GetP<Privacy>().ParseFromXml( node );
                    break;
                case "privacy_comment":
                    entity.PrivacyComment = this.GetP<Privacy>().ParseFromXml(node);
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
