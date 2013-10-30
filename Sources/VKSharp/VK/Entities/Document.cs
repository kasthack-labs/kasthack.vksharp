using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Document : IVKEntity<Document> {
        public uint ID { get; set; }
        public int OwnerID { get; set; }
        public string Title { get; set; }
        public uint Size { get; set; }
        public string Url { get; set; }
        public string Photo100 { get; set; }
        public string Photo130 { get; set; }
        public IVKEntityParser<Document> GetParser() {
            throw new NotImplementedException();
        }
    }
}
