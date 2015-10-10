using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VKSharp.Helpers {
    // "enum_value" -> Enum.EnumValue
    internal class SnakeCaseEnumConverter : StringEnumConverter {
        public override bool CanConvert( Type objectType ) {
            if ( objectType.IsNullable() )
                objectType = Nullable.GetUnderlyingType( objectType );
            return objectType.IsEnum;
        }
        public new bool AllowIntegerValues { get { return base.AllowIntegerValues; } set { base.AllowIntegerValues = value; } }
        public override bool CanWrite => true;
        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            var isNullable = objectType.IsNullable();
            var t = isNullable ? Nullable.GetUnderlyingType( objectType ) : objectType;
            if ( reader.TokenType == JsonToken.Null ) {
                if ( !isNullable )
                    throw new JsonSerializationException($"Cannot convert null value to {objectType}.");
                return null;
            }
            try {
                switch ( reader.TokenType ) {
                    case JsonToken.String:
                        return Enum.Parse(t, reader.Value.ToString().ToMeth(), true);
                    case JsonToken.Integer:
                        return base.ReadJson(reader, objectType, existingValue, serializer);
                }
            }
            catch ( Exception ex ) {
                throw new JsonSerializationException($"Error converting value {reader.Value} to type '{objectType}'.", ex );
            }
            throw new JsonSerializationException( $"Unexpected token {reader.TokenType.ToNCString()} when parsing enum.");
        }
    }

}