namespace VKSharp.Core.Interfaces {
    public abstract class OwnedEntity<T>  {
        public long Id { get; set; }
        public int OwnerId { get; set; }
        
    }
}
