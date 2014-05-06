using System;

namespace VKSharp.Helpers.Exceptions {
    public class VKException:Exception {
        public VKException( string message ):base(message) {
        }
    }
}
