namespace kasthack.vksharp.DataTypes.Entities {
    public class PostLikes : Counter {
        public bool? UserLikes { get; set; }
        public bool? CanLike { get; set; }
        public bool? CanPublish { get; set; }
    }
}
