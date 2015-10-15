using System;

namespace kasthack.vksharp {
    public class VkException:Exception {
        public VkException( string message, int code =-1 ):base(message) { Code = code; }
        public int Code { get; }
    }
}
