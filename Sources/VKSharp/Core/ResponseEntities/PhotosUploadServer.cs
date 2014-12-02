using VKSharp.Core.Interfaces;

namespace VKSharp.Core.ResponseEntities
{
    public class PhotosUploadServer : IVKEntity<PhotosUploadServer> {

        public string UploadUrl { get; set; }
        public int UserId { get; set; }
        public long AlbumId { get; set; }
        
    }
}
