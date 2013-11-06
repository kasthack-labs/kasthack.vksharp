using VKSharp.Core.EntityParsers;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class School:IVKEntity<School> {
        public uint ID { get; set; }
        public uint Country { get; set; }
        public uint City { get; set; }
        public string Name { get; set; }
        public ushort? YearFrom { get; set; }
        public ushort? YearTo { get; set; }
        public ushort? Graduation { get; set; }
        public string Class { get; set; }
        public string Speciality { get; set; }
        public uint Type { get; set; }
        public uint TypeName { get; set; }
        public IVKEntityParser<School> GetParser() {
            return SchoolParser.Instanse;
        }
    }
}
