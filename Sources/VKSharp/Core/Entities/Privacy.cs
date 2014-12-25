using VKSharp.Core.Enums;

namespace VKSharp.Core.Entities {
    public class Privacy {
        public PrivacyType Type { get; set; }
        public int[] Lists { get; set; }
        public int[] ExceptLists { get; set; }
        public int[] Users { get; set; }
        public int[] ExceptUsers { get; set; }
    }
}
