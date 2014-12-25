using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Document : OwnedEntity<Document> {
        public string Title { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        public string Photo100 { get; set; }
        public string Photo130 { get; set; }

        public string Ext { get; set; }
    }
}
