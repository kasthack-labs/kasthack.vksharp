using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities
{
    public class Status : IVKEntity<Status> {
        public VKApi Context { get; set; }
        public string Text { get; set; }
    }
}
