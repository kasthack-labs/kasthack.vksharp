using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class DatabaseCity : DatabaseEntry, IVKEntity<DatabaseCity> {
        public bool Important { get; set; }
    }
}
