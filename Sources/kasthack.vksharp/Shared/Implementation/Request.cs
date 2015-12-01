using System.Collections.Generic;

namespace kasthack.vksharp.Implementation {
    public class Request<T> {
        public string MethodName { get; set; }
        public Token Token { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
    }
}