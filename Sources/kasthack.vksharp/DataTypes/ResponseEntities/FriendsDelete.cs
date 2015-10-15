namespace kasthack.vksharp.DataTypes.ResponseEntities
{
    public class FriendsDelete
    {
        public bool Success { get; set; }
        public bool FriendDeleted { get; set; }
        public bool OutRequestDeleted { get; set; }
        public bool InRequestDeleted { get; set; }
        public bool SuggestionDeleted { get; set; }
    }
}
