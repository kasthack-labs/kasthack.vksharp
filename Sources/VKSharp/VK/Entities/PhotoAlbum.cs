using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {

    public class PhotoAlbum:IVKEntity<PhotoAlbum> {
        public uint ID { get; set; }
        public int OwnerID { get; set; }
        public Photo Thumb { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint CreatedDate { get; set; }
        public uint UpdatedDate { get; set; }
        public uint Size { get; set; }
        public IVKEntityParser<PhotoAlbum> GetParser() {
            return PhotoAlbumParser.Instanse;
        }
    }
}
