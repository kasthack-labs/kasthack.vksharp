using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using VKSharp.Core.EntityFragments;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Helpers {
    //snake case property mapping UserId->"user_id"
    internal class SnakeCaseContractResolver : DefaultContractResolver {
        protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
    }
    
    //https://stackoverflow.com/questions/17745866
    //converts doubles|strings -> ints
    internal class CustomIntConverter : JsonConverter {
        public override bool CanConvert( Type objectType ) => objectType == typeof(int);

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

    /*
        [] -> null
        {...} -> parse
    */
    internal class ObjectArrConverter<T> : JsonConverter {
        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) => JObject.FromObject( value ).WriteTo( writer );

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            if ( reader.TokenType != JsonToken.StartArray )
                return serializer.Deserialize<T>( reader );
            reader.Skip();
            reader.Skip();
            return existingValue;
        }
        public override bool CanConvert( Type objectType ) => objectType == typeof(T);
    }
    // "enum_value" -> Enum.EnumValue
    internal class SnakeCaseEnumConverter : StringEnumConverter {
        public override bool CanConvert( Type objectType ) {
            if ( IsNullableType(objectType) )
                objectType = Nullable.GetUnderlyingType( objectType );
            return objectType.IsEnum;
        }

        public override bool CanWrite => true;

        private static bool IsNullableType(Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == typeof (Nullable<>);
        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            var isNullable = IsNullableType( objectType );
            var t = isNullable ? Nullable.GetUnderlyingType( objectType ) : objectType;
            if ( reader.TokenType == JsonToken.Null ) {
                if ( !IsNullableType( objectType ) )
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

    //vk's date converter
    public class DateConverter : JsonConverter {
        private static readonly Type Type = typeof(Date);

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) {
            throw new NotImplementedException();
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            if ( reader.TokenType == JsonToken.None ) return default(Date);
            Date p;
            return Date.TryParse( reader.Value.ToString(), out p ) ? p : default(Date);
        }
        public override bool CanConvert( Type objectType ) => Type == objectType;

        public override bool CanWrite => false;
    }
}
