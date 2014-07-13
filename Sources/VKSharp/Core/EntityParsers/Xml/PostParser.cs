using System.Xml.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostParser : DefaultParser<Post> {
        public override bool UpdateFromFragment( XElement node, Post entity ) {
            if ( base.UpdateFromFragment( node, entity ) ) return true;
            var changed = true;
            switch ( node.Name.ToString() ) {
                case "comments":
                    entity.Comments = GetP<PostComments>().ParseFromXml( node );
                    break;
                case "likes":
                    entity.Likes = GetP<PostLikes>().ParseFromXml(node);
                    break;
                case "reposts":
                    entity.Reposts = GetP<PostReposts>().ParseFromXml(node);
                    break;
                case "post_source":
                    entity.PostSource = GetP<PostSource>().ParseFromXml(node);
                    break;
                case "geo":
                    entity.Geo = GetP<Geo>().ParseFromXml(node);
                    break;
                case "copy_history":
                    entity.CopyHistory = ParseAllFromXml( node.Elements() );
                    break;
                case "attachments":
                    entity.Attachments = GetP<Attachment>().ParseAllFromXml( node.Elements() );
                    break;
                default:
                    changed = false;
                    break;
            }
            return changed;
        }
    }
}
