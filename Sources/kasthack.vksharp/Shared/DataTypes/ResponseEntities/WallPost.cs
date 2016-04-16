namespace kasthack.vksharp.DataTypes.ResponseEntities {
    public class WallPost {
        public int PostId { get; set; }
        public static implicit operator int (WallPost post) => post.PostId;
        public static implicit operator WallPost(int postId) => new WallPost() { PostId = postId };
    }
    public class CommentPost {
        public int CommentId { get; set; }
        public static implicit operator int(CommentPost post) => post.CommentId;
        public static implicit operator CommentPost(int commentId) => new CommentPost() { CommentId = commentId };
    }
}
