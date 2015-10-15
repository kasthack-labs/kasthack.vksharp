namespace kasthack.vksharp.DataTypes.ResponseEntities {
    public class WallPost {
        public int PostId { get; set; }
        public static implicit operator int (WallPost post) => post.PostId;
        public static implicit operator WallPost(int postId) => new WallPost() { PostId = postId };
    }
}
