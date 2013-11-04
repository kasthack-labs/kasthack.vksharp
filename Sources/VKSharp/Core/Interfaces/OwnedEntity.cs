namespace VKSharp.VK.Interfaces {
    public abstract class OwnedEntity<T> : IVKEntity<T> where T : IVKEntity<T> {
        public virtual ulong ID { get; set; }
        public virtual int OwnerID { get; set; }
        public abstract IVKEntityParser<T> GetParser();
    }
}
