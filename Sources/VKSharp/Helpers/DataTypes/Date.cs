using System;
using Newtonsoft.Json;

namespace VKSharp.Helpers.DataTypes {
    [JsonConverter(typeof(DateConverter))]
    public struct Date {
        public int? Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        //TODO: replace try-catch checks
        public static bool TryParse(string sim, out Date date ) {
            date = default( Date );
            try{
                date = Parse(sim);
                return true;
            }
            catch{
                return false;
            }
        }
        public static Date Parse(string innerText) {
            var spl = innerText.Split('.');
            var l = spl.Length;
            return new Date {
                Year = l>2?(int?) int.Parse( spl[ --l ] ) : null,
                Month = int.Parse( spl[ --l ] ),
                Day=int.Parse(spl[--l]),
            };
        }
        public override string ToString() {
            return String.Format(
                Year != null ? "{0:D2}.{1:D2}.{2:D4}" : "{0:D2}.{1:D2}",
                Day,
                Month,
                Year
            );
        }
    }

    
    public class DateConverter : JsonConverter {
        private static readonly Type Type = typeof( Date );

        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer ) {
            throw new NotImplementedException();
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
            if ( reader.TokenType == JsonToken.None ) return default(Date);
            Date p;
            return Date.TryParse( reader.Value.ToString(), out p ) ? p : default( Date );
        }
        public override bool CanConvert( Type objectType ) { return Type == objectType; }
    }
}
