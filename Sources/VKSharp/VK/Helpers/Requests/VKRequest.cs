using System.Collections.Generic;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Helpers.Requests {
    public class VKRequest<T> where T : IVKEntity<T> {
        public string MethodName { get; private set; }
        public Dictionary<string, object> Parameters { get; private set; }
        public IVKEntityParser<T> Parser { get; private set; }
    }
}