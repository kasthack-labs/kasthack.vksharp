using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Geo:IVKEntity<Geo> {
        public uint PlaceID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public uint CountryID { get; set; }
        public uint CityID { get; set; }
        public string Address { get; set; }
        public IVKEntityParser<Geo> GetParser() {
            return GeoParser.Instanse;
        }
    }
}
