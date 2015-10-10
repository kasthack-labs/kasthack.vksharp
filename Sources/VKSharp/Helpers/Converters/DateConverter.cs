using System;
using Newtonsoft.Json;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Helpers {

    // "01.01.1970" => VK's Date
    public class DateConverter : JsonConverter {
        private static readonly Type Type = typeof(Date);

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) {
            if ( value == null ) {
                writer.WriteNull();
                return;
            }
            writer.WriteValue(((Date)value).ToString());
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            if ( reader.TokenType != JsonToken.String && !( reader.TokenType == JsonToken.Null && objectType.IsNullable() ) )
                throw new JsonSerializationException( $"Unexpected token {reader.TokenType.ToNCString()} when parsing a date." );
            Date p;
            return Date.TryParse( reader.Value.ToString(), out p ) ? p : existingValue;
        }

        public override bool CanConvert( Type objectType ) {
            if (objectType.IsNullable())
                objectType = Nullable.GetUnderlyingType(objectType);
            return Type == objectType;
        }

        public override bool CanWrite => true;
    }

}
