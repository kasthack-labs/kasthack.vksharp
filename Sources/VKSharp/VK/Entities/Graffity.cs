using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Graffity:IVKEntity<Graffity> {
        public uint ID { get; set; }
        public int OwnerID { get; set; }
        public string Photo200 { get; set; }
        public string Photo586 { get; set; }
        
        public IVKEntityParser<Graffity> GetParser() {
            return GraffityParser.Instanse;
        }
    }
}
