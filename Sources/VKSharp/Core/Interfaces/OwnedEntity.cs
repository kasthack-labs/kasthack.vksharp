namespace VKSharp.Core.Interfaces {
    public abstract class OwnedEntity<T> : IVKEntity<T> where T : IVKEntity<T> {
        public virtual ulong Id { get; set; }
        public virtual int OwnerId { get; set; }
        public VKApi Context { get; set; }
    }
}
