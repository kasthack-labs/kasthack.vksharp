using System;

namespace kasthack.vksharp.Internal {
    public static class DateTimeOffsetHelper {
#if NET_46_GT
        public static int ToUnixTimeSeconds(this DateTimeOffset offset) => (int) offset.ToUnixTimeSeconds();

        public static DateTimeOffset FromUnixTimeSeconds(long seconds) => DateTimeOffset.FromUnixTimeSeconds( seconds );
#else
        private static readonly DateTimeOffset sTime = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        public static int ToUnixTimeSeconds(this DateTimeOffset offset) {
            return (int) (offset - sTime).TotalSeconds;
        }

        public static DateTimeOffset FromUnixTimeSeconds(long seconds) {
            return sTime.AddSeconds(seconds);
        }
#endif
    }
}
