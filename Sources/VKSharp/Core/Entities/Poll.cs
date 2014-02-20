using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Poll:IVKEntity<Poll> {
        public int OwnerID { get; set; }
        public uint PollID { get; set; }
        public uint Created { get; set; }
        public uint Votes { get; set; }
        public uint AnswerID { get; set; }

        public VKApi Context { get; set; }
    }
}
