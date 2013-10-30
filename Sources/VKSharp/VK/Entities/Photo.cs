using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Photo:IVKEntity<Photo> {
        public uint ID { get; set; }
        public int OwnerID { get; set; }
        public int AlbumID { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public string Text { get; set; }
        public uint Date { get; set; }
        public IVKEntityParser<Photo> GetParser() {
            return PhotoParser.Instanse;
        }
    }
}
