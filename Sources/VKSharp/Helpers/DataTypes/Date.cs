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
            return new Date() {
                Day=int.Parse(spl[--l]),
                Month = int.Parse( spl[ --l ] ),
                Year = l>0?(int?)int.Parse( spl[ --l ] ):null
            };
        }
    }
}
