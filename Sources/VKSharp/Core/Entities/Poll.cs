namespace VKSharp.Core.Entities {
    public class Poll {
        public int OwnerId { get; set; }
        public int PollId { get; set; }
        public int Created { get; set; }
        public int Votes { get; set; }
        public int AnswerId { get; set; }
    }
}
