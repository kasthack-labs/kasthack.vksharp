using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class StorageEntry : IVKEntity<StorageEntry> {
        public VKApi Context { get; set; }

        public string Value { get; set; }
        public string Key { get; set; }
    }
}
