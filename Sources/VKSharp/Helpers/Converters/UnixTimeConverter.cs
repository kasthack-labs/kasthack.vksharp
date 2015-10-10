using System;
using Newtonsoft.Json;

namespace VKSharp.Helpers {

    public class UnixTimeConverter : JsonConverter {

        private static readonly Type DateTimeType = typeof( DateTime );
        private static readonly Type DateTimeOffsetType = typeof( DateTimeOffset );

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) {
            if ( value == null ) {
                writer.WriteNull();
                return;
            }
            long ser;

            var type = value.GetType();
            if ( type.IsNullable() )
                type = Nullable.GetUnderlyingType( type );

            if ( type == DateTimeOffsetType )
                ser = ( (DateTimeOffset) value ).ToUnixTimeSeconds();
            else if ( type == DateTimeType )
                ser = new DateTimeOffset( ( (DateTime) value ) ).ToUnixTimeSeconds();
            else throw new JsonSerializationException( $"Can't serialize {type}" );
            writer.WriteValue( ser );
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            switch ( reader.TokenType ) {
                case JsonToken.Integer:
                    var dto = DateTimeOffset.FromUnixTimeSeconds( (long) reader.Value );
                    if ( objectType == DateTimeOffsetType || ( objectType.IsNullable() && Nullable.GetUnderlyingType( objectType ) == DateTimeOffsetType ) )
                        return dto;
                    return dto.DateTime;
                case JsonToken.Null:
                    if ( objectType.IsNullable() )
                        return null;
                    throw new JsonSerializationException( $"Can't deserialize null value to non-nullable type" );
                default:
                    throw new JsonSerializationException( $"Unexpected token {reader.TokenType.ToNCString()} when parsing a date." );
            }
        }

        public override bool CanConvert( Type objectType ) {
            if ( objectType.IsNullable() ) objectType = Nullable.GetUnderlyingType( objectType );
            return objectType == DateTimeOffsetType || objectType == DateTimeType;
        }

    }

}