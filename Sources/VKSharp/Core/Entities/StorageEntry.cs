using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class StorageEntry : IVKEntity<StorageEntry> {
        

        public string Value { get; set; }
        public string Key { get; set; }
    }
}
