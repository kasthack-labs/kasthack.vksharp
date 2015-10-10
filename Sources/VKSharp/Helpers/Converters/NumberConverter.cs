using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VKSharp.Helpers {
    //https://stackoverflow.com/questions/17745866
    //converts doubles|strings -> ints
    // "1" -> 1
    // 1.0 -> 1
    // 1 -> 1
    internal class NumberConverter<T> : JsonConverter {

        private readonly Func<string, T> _parse;

        private static readonly Type NumberType = typeof(T);
        private static readonly TypeCode NumberTypeCode = Type.GetTypeCode( NumberType );

        public NumberConverter( Func<string, T> parse ) { _parse = parse; }

        public override bool CanConvert( Type objectType ) {
            if ( objectType.IsNullable() )
                objectType = Nullable.GetUnderlyingType( objectType );
            return objectType == NumberType;
        }
        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            var jsonValue = serializer.Deserialize<JValue>( reader );
            switch ( jsonValue.Type ) {
                case JTokenType.Float:
                    return Convert.ChangeType( Math.Round( jsonValue.Value<double>()), NumberTypeCode );
                case JTokenType.Integer:
                    return jsonValue.Value<T>();
                case JTokenType.String:
                    return _parse( jsonValue.Value<string>() );
                case JTokenType.Null:
                    if ( !objectType.IsNullable() )
                        throw new JsonSerializationException($"Cannot convert null value to {objectType}.");
                    return null;
                default:
                    throw new JsonSerializationException($"Unexpected token {reader.TokenType.ToNCString()} when parsing a number.");
            }
        }
        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) => JObject.FromObject( value ).WriteTo( writer );
    }

}