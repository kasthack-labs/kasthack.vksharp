using System;
using kasthack.vksharp.DataTypes.EntityFragments;
using Newtonsoft.Json;

namespace kasthack.vksharp.Internal.Converters {

    public class ArrConverter : JsonConverter {

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) { throw new NotImplementedException(); }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            if ( reader.TokenType != JsonToken.StartArray ) throw new JsonSerializationException( "StartArray expected" );
            var ret = new DatabaseClass();
            if ( !reader.Read()) throw new JsonSerializationException("Unexpected end");
            ret.Id = serializer.Deserialize<int>( reader );
            if ( !reader.Read() ) throw new JsonSerializationException( "Unexpected end" );
            ret.Name = reader.Value.ToString();
            reader.Read();
            if ( reader.TokenType != JsonToken.EndArray ) throw new JsonSerializationException( "EndArray expected" );
            return ret;
        }

        public override bool CanConvert( Type objectType ) => objectType == typeof( DatabaseClass );

        public override bool CanWrite => false;

    }

}