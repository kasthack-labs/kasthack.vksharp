using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using VKSharp.Core.EntityFragments;

namespace VKSharp.Helpers {

    internal class SnakeCaseContractResolver : DefaultContractResolver {
        protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
    }
    //https://stackoverflow.com/questions/17745866
    internal class CustomIntConverter : JsonConverter {
        public override bool CanConvert( Type objectType ) {
            return ( objectType == typeof(int) );
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            var jsonValue = serializer.Deserialize<JValue>( reader );
            switch ( jsonValue.Type ) {
                case JTokenType.Float:
                    return (int)Math.Round( jsonValue.Value<double>() );
                case JTokenType.Integer:
                    return jsonValue.Value<int>();
                case JTokenType.String:
                    return int.Parse( jsonValue.Value<string>() );
            }
            throw new FormatException();
        }

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) => JObject.FromObject( value ).WriteTo( writer );
    }

    internal class PersonalConverter : JsonConverter {
        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) => JObject.FromObject( value ).WriteTo( writer );

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            if ( reader.TokenType == JsonToken.StartArray ) {
                reader.Skip();
                reader.Skip();
                return existingValue;
            }
            return serializer.Deserialize<StandInLife>( reader );
        }
        public override bool CanConvert( Type objectType ) => objectType == typeof( StandInLife );
    }
}
