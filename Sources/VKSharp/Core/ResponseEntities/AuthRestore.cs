using VKSharp.Core.Interfaces;

namespace VKSharp.Core.ResponseEntities {
    public class AuthRestore : IVKEntity<AuthRestore> {
        
        public bool Success { get; set; }
        public string Sid { get; set; }
    }
}
