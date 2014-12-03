using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class DatabaseCity : DatabaseEntry, IVKEntity<DatabaseCity> {
        public string Area { get; set; }
        public string Region { get; set; }
        public bool Important { get; set; }
    }
}
