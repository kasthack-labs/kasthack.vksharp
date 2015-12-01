using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.Entities {
    public class PostSource  {
        public PostSourceType SourceType { get; set; }
        public PostSourceInfo? Data { get; set; }
    }
}
