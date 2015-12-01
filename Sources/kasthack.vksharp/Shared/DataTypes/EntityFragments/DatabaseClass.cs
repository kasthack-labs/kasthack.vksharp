using kasthack.vksharp.Internal.Converters;
using Newtonsoft.Json;

namespace kasthack.vksharp.DataTypes.EntityFragments {

    [JsonConverter( typeof( ArrConverter ) )]
    public class DatabaseClass {

        public int Id { get; set; }
        public string Name { get; set; }

    }

}