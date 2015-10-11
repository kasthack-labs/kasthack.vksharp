using System;
using Newtonsoft.Json;

namespace VKSharp.Helpers.Converters {

    // fuck vk and their developers 
    // 1-> true
    // 2-> false
    public class OneTwoFUConverter : JsonConverter {

        private const int False = 2;
        private const int True = 1;

        private static readonly Type NullableType = typeof( bool? );

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) {
            if ( value == null ) writer.WriteNull();
            var v = (bool) value;
            writer.WriteValue( v ? True : False );
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            switch ( reader.TokenType ) {
                case JsonToken.Integer:
                    var v = (int) reader.Value;
                    switch ( v ) {
                        case True:
                            return true;
                        case False:
                            return false;
                        default:
                            throw new JsonSerializationException( $"Error converting value {reader.Value} to type '{objectType}'." );
                    }
                case JsonToken.Boolean:
                    return reader.Value;
                case JsonToken.Null:
                    if ( objectType == NullableType )
                        return null;
                    throw new JsonSerializationException( $"Error converting null to type '{objectType}'." );
                default:
                    throw new JsonSerializationException( $"Unexpected token {reader.TokenType.ToNCString()} when parsing enum." );
            }
        }

        public override bool CanConvert( Type objectType ) => objectType == typeof( bool ) || objectType == NullableType;

    }

}