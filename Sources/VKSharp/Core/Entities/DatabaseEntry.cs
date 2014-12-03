using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class DatabaseEntry : IVKEntity<DatabaseEntry> {
        public string Title { get; set; }
        public int Id { get; set; }
    }
}
