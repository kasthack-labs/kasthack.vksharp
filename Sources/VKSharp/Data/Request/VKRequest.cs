using System.Collections.Generic;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers.Api;

namespace VKSharp.Data.Request {
    public class VKRequest<T> where T : IVKEntity<T> {
        public string MethodName { get; set; }
        public VKToken Token { get; set }
        public Dictionary<string, string> Parameters { get; set; }
    }
}