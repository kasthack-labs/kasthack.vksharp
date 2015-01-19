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

    internal class SnakeCaseContractResolver : DefaultContractResolver {
        protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
    }
    //https://stackoverflow.com/questions/17745866
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
    internal class ObjectArrConverter<T>:JsonConverter {
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

    internal class PersonalConverter : ObjectArrConverter<StandInLife> { }

    internal class SnakeCaseEnumConverter : StringEnumConverter {
        public override bool CanConvert( Type objectType ) {
            var btype = objectType;
            if ( objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>) )
                btype = Nullable.GetUnderlyingType( objectType );
            return btype.IsEnum;
        }

        public override bool CanWrite => true;
        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) {
            base.WriteJson( writer, value, serializer );
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            var isNullable = ReflectionUtils.IsNullableType( objectType );
            var t = isNullable ? Nullable.GetUnderlyingType( objectType ) : objectType;
            if ( reader.TokenType == JsonToken.Null ) {
                if ( !ReflectionUtils.IsNullableType( objectType ) )
                    throw JsonSerializationException.Create( reader, "Cannot convert null value to {0}.".FormatWith( CultureInfo.InvariantCulture, objectType ) );
                return null;
            }
            try {
                switch ( reader.TokenType ) {
                    case JsonToken.String:
                        var enumText = reader.Value.ToString()
                                             .ToMeth();//the only changed line
                        return EnumUtils.ParseEnumName( enumText, isNullable, t );
                    case JsonToken.Integer:
                        if ( !AllowIntegerValues )
                            throw JsonSerializationException.Create( reader, "Integer value {0} is not allowed.".FormatWith( CultureInfo.InvariantCulture, reader.Value ) );
                        return ConvertUtils.ConvertOrCast( reader.Value, CultureInfo.InvariantCulture, t );
                }
            }
            catch ( Exception ex ) {
                throw JsonSerializationException.Create( reader, "Error converting value {0} to type '{1}'.".FormatWith( CultureInfo.InvariantCulture, MiscellaneousUtils.FormatValueForPrint( reader.Value ), objectType ), ex );
            }
            // we don't actually expect to get here.
            throw JsonSerializationException.Create( reader, "Unexpected token {0} when parsing enum.".FormatWith( CultureInfo.InvariantCulture, reader.TokenType ) );
        }
    }
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
