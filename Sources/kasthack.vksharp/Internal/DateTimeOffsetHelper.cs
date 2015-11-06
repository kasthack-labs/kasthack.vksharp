using System;

namespace kasthack.vksharp.Internal {
    public static class DateTimeOffsetHelper {

        private static readonly DateTimeOffset sTime = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        public static int ToUnixTimeSeconds(this DateTimeOffset offset) {
            return (int) (offset - sTime).TotalSeconds;
        }

        public static DateTimeOffset FromUnixTimeSeconds(long seconds) {
            return sTime.AddSeconds(seconds);
        }

    }
}
