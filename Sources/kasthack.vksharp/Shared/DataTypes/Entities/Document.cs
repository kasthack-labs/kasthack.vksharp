using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Document : OwnedEntity {
        public string Title { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        public string Photo100 { get; set; }
        public string Photo130 { get; set; }

        public string Ext { get; set; }

        public static implicit operator ObjectContentId(Document doc)=> new ObjectContentId( ContentType.Doc, doc.Id, doc.OwnerId );

        public static implicit operator ContentId(Document doc) => (ObjectContentId)doc;
    }
}
