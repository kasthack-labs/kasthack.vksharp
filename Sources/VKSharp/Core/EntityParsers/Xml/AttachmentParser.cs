using System;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AttachmentParser : DefaultParser<Attachment> {
        public override bool UpdateFromFragment (XElement node, Attachment entity) {
            if ( node.Name == "type" || entity.Type == null ) return base.UpdateFromFragment( node, entity );
            switch ( entity.Type.Value ) {
                case AttachmentType.Photo:
                    entity.AttachmentBody = GetP<Photo>().ParseFromXml( node );
                    break;
                case AttachmentType.PostedPhoto:
                    entity.AttachmentBody = GetP<PostedPhoto>().ParseFromXml( node );
                    break;
                case AttachmentType.Video:
                    entity.AttachmentBody = GetP<Video>().ParseFromXml( node );
                    break;
                case AttachmentType.Audio:
                    entity.AttachmentBody = GetP<Audio>().ParseFromXml( node );
                    break;
                case AttachmentType.Doc:
                    entity.AttachmentBody = GetP<Document>().ParseFromXml( node );
                    break;
                case AttachmentType.Graffiti:
                    entity.AttachmentBody = GetP<Graffity>().ParseFromXml( node );
                    break;
                case AttachmentType.Link:
                    entity.AttachmentBody = GetP<Link>().ParseFromXml( node );
                    break;
                case AttachmentType.Note:
                    entity.AttachmentBody = GetP<Note>().ParseFromXml( node );
                    break;
                case AttachmentType.App:
                    //entity.AttachmentBody = GetP<App>().ParseFromXml( node );
                    break;
                case AttachmentType.Poll:
                    entity.AttachmentBody = GetP<Poll>().ParseFromXml( node );
                    break;
                case AttachmentType.Page:
                    //entity.AttachmentBody = GetP<Wi>().ParseFromXml( node );
                    break;
                case AttachmentType.Album:
                    entity.AttachmentBody = GetP<PhotoAlbum>().ParseFromXml( node );
                    break;
                case AttachmentType.PhotosList:
                    entity.AttachmentBody = GetP<EntityList<Photo>>().ParseFromXml( node );
                    break;
                default:
                    throw new ArgumentOutOfRangeException ();
            }
            return base.UpdateFromFragment(node, entity);
        }
    }
}
