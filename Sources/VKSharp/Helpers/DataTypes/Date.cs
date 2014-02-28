using System;

namespace VKSharp.Helpers.DataTypes {
    public class Date {
        public int? Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public static Date Parse(string innerText) {

            var spl = innerText.Split('.');
            var l = spl.Length;
            //if(l==0)
            //    return null
            return new Date {
                Year = l>2?(int?) int.Parse( spl[ --l ] ) : null,
                Month = int.Parse( spl[ --l ] ),
                Day=int.Parse(spl[--l]),
            };
        }

        /// <summary>
        /// Возвращает строку, которая представляет текущий объект.
        /// </summary>
        /// <returns>
        /// Строка, представляющая текущий объект.
        /// </returns>
        public override string ToString() {
            return String.Format(
                Year != null ? "{0:D2}.{1:D2}.{2:D4}" : "{0:D2}.{1:D2}",
                Day,
                Month,
                Year
            );
        }
    }
}
