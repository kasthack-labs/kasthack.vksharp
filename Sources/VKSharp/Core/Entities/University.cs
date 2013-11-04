using VKSharp.Core.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class University: IVKEntity<University> {
        public uint ID { get; set; }
        public uint Country { get; set; }
        public uint City { get; set; }
        public string Name { get; set; }
        public uint? Faculty { get; set; }
        public string FacultyName { get; set; }
        public uint? Chair { get; set; }
        public string ChairName { get; set; }
        public ushort? Graduation { get; set; }
        public IVKEntityParser<University> GetParser() {
            return UniversityParser.Instanse;
        }
    }
}
