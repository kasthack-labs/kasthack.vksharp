using VKSharp.Core.EntityParsers;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class Graffity : OwnedEntity<Graffity> {

        public string Photo200 { get; set; }
        public string Photo586 { get; set; }

        public override IVKEntityParser<Graffity> GetParser() {
            return GraffityParser.Instanse;
        }
    }
}
