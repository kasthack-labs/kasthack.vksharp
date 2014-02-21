using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class BanInfo : IVKEntity<BanInfo> {
        public uint AdminId{ get; set; }
        public uint AddDate { get; set; }
        public uint EndDate { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }

        public VKApi Context { get; set; }
    }
}
