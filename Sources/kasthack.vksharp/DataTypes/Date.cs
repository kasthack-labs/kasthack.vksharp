using System;
using kasthack.vksharp.Internal.Converters;
using Newtonsoft.Json;

namespace kasthack.vksharp.DataTypes {
    [JsonConverter(typeof(DateConverter))]
    public struct Date : IFormattable{
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

        public string ToString( string format, IFormatProvider formatProvider ) {
            return String.Format(
                formatProvider,
                Year != null ? "{0:D2}.{1:D2}.{2:D4}" : "{0:D2}.{1:D2}",
                Day,
                Month,
                Year
            );
        }

    }
}
