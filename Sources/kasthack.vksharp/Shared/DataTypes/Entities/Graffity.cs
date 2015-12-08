using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Graffity : OwnedEntity {

        public string Photo200 { get; set; }
        public string Photo586 { get; set; }

        public static implicit operator ObjectContentId(Graffity doc) => new ObjectContentId(ContentType.Graffiti, doc.Id, doc.OwnerId);

        public static implicit operator ContentId(Graffity doc) => (ObjectContentId)doc;

    }
}
