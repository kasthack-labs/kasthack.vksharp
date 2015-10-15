using Newtonsoft.Json.Serialization;

namespace kasthack.vksharp.Internal.Converters {
    // snake case property mapping UserId->"user_id"
    internal class SnakeCaseContractResolver : DefaultContractResolver {
        protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
    }

}