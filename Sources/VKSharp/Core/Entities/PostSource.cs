using VKSharp.Core.EntityParsers;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class PostSource:IVKEntity<PostSource> {
        public PostSourceType SourceType { get; set; }
        public PostSourceInfo? Data { get; set; }
        public IVKEntityParser<PostSource> GetParser() {
            return PostSourceParser.Instanse;
        }
    }
}
