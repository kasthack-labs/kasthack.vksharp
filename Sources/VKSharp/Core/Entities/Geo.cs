using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Geo:IVKEntity<Geo> {
        
        public string Address { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public uint CityID { get; set; }
        public uint CountryID { get; set; }
        public uint PlaceID { get; set; }

        public VKApi Context { get; set; }
    }
}
