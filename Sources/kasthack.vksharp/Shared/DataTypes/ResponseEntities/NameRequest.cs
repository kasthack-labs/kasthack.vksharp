using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.ResponseEntities
{
    public class NameRequest {
        public long Id { get; set; }
        public NameRequestStatus Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RepeatDate { get; set; }//TODO: investigate date format
    }
}
