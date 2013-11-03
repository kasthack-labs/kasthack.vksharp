using VKSharp.VK.EntityParsers;
using VKSharp.VK.Helpers.DataTypes;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class PostSource:IVKEntity<PostSource> {
        public PostSourceType SourceType { get; set; }
        public PostSourceInfo? Data { get; set; }
        public IVKEntityParser<PostSource> GetParser() {
            return PostSourceParser.Instanse;
        }
    }
}
