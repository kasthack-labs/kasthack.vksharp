using System;
using VKSharp.VK.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Document : IVKEntity<Document> {
        public ulong ID { get; set; }
        public int OwnerID { get; set; }
        public string Title { get; set; }
        public uint Size { get; set; }
        public string Url { get; set; }
        public string Photo100 { get; set; }
        public string Photo130 { get; set; }
        public IVKEntityParser<Document> GetParser() {
            return DocumentParser.Instanse;
        }
    }
}
