using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.DataTypes.Interfaces;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Poll : OwnedEntity {
        //different formats
        public long PollId { get { return Id; } set { Id = value; } }
        public int Created { get; set; }
        public int Votes { get; set; }
        public int AnswerId { get; set; }

        public static implicit operator ObjectContentId(Poll poll) => new ObjectContentId( ContentType.Poll, poll.Id, poll.OwnerId );
        public static implicit operator ContentId(Poll poll) => (ObjectContentId)poll;
    }
}
