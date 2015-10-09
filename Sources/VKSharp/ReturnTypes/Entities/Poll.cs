using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Poll : OwnedEntity {
        //different formats
        public long PollId { get { return Id; } set { Id = value; } }
        public int Created { get; set; }
        public int Votes { get; set; }
        public int AnswerId { get; set; }
    }
}
