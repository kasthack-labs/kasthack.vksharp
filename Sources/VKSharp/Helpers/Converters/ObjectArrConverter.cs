using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VKSharp.Helpers {
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

}