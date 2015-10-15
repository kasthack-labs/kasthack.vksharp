namespace kasthack.vksharp.DataTypes.Interfaces {
    public abstract class OwnedEntity  {
        public long Id { get; set; }
        public int OwnerId { get; set; }
    }
}
