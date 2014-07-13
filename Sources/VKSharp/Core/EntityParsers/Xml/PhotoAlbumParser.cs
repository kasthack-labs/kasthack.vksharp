using System.Xml.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoAlbumParser : DefaultParser<PhotoAlbum> {
        public override bool UpdateFromFragment( XElement node, PhotoAlbum entity ) {
            if ( base.UpdateFromFragment( node, entity ) )
                return true;
            switch ( node.Name.ToString().ToLowerInvariant() ) {
                case "privacy_view":
                case "privacy"://photos.createAlbum
                    entity.PrivacyView = GetP<Privacy>().ParseFromXml( node );
                    break;
                case "privacy_comment":
                case "comment_privacy"://photos.createAlbum
                    entity.PrivacyComment = GetP<Privacy>().ParseFromXml(node);
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
