using System;

namespace VKSharp.Helpers.Exceptions {
    public class VKException:Exception {
        public VKException( string message, int code =-1 ):base(message) { Code = code; }
        public int Code { get; }
    }
}
