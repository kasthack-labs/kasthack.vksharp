namespace VKSharp.Core.Interfaces {
    public abstract class OwnedEntity<T> : IVKEntity<T> where T : IVKEntity<T> {
        public ulong Id { get; set; }
        public int OwnerId { get; set; }
        public VKApi Context { get; set; }
    }
}
