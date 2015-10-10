using Newtonsoft.Json.Serialization;

namespace VKSharp.Helpers {
    // snake case property mapping UserId->"user_id"
    internal class SnakeCaseContractResolver : DefaultContractResolver {
        protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
    }

}