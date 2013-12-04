namespace VKSharp.Core.Interfaces {
    public abstract class OwnedEntity<T> : IVKEntity<T> where T : IVKEntity<T>, new() {
        public virtual ulong ID { get; set; }
        public virtual int OwnerID { get; set; }
        public VKApi Context { get; set; }
    }
}
