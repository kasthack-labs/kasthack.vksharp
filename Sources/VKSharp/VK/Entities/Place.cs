using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Place:IVKEntity<Place> {
        public uint ID { get; set; }
        public uint Title { get; set; }
        public uint Latitude { get; set; }
        public uint Longitude { get; set; }
        public uint Country { get; set; }
        public string Type { get; set; }
        public uint City { get; set; }
        public string Address { get; set; }
        public IVKEntityParser<Place> GetParser() {
            return PlaceParser.Instanse;
        }
    }
}
