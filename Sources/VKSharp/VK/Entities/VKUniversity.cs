using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKSharp.VK.Entities {
    public class VKUniversity {
        public uint ID { get; set; }
        public uint Country { get; set; }
        public uint City { get; set; }
        public string Name { get; set; }
        public uint? Faculty { get; set; }
        public string FacultyName { get; set; }
        public uint? Chair { get; set; }
        public string ChairName { get; set; }
        public ushort? Graduation { get; set; }
    }
}
