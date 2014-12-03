using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class University: IVKEntity<University> {
        public string ChairName { get; set; }
        public string FacultyName { get; set; }
        public string Name { get; set; }
        public string EducationForm { get; set; }
        public string EducationStatus { get; set; }
        public uint City { get; set; }
        public uint Country { get; set; }
        public uint Id { get; set; }
        public uint? Chair { get; set; }
        public uint? Faculty { get; set; }
        public ushort? Graduation { get; set; }

    }
}
