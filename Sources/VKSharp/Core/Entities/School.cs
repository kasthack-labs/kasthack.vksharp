using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class School:IVKEntity<School> {
        public string Class { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public uint City { get; set; }
        public uint Country { get; set; }
        public uint ID { get; set; }
        public uint Type { get; set; }
        public uint TypeStr { get; set; }
        public ushort? YearGraduated { get; set; }
        public ushort? YearFrom { get; set; }
        public ushort? YearTo { get; set; }

        public VKApi Context { get; set; }
    }
}
