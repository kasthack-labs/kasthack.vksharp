using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Poll:IVKEntity<Poll> {
        public int OwnerId { get; set; }
        public uint PollId { get; set; }
        public uint Created { get; set; }
        public uint Votes { get; set; }
        public uint AnswerId { get; set; }

        public VKApi Context { get; set; }
    }
}
