using System;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.Entities {
    public class Poll:IVKEntity<Poll> {
        public int OwnerID { get; set; }
        public uint PollID { get; set; }
        public uint Created { get; set; }
        public uint Votes { get; set; }
        public uint AnswerID { get; set; }
        public IVKEntityParser<Poll> GetParser() {
            throw new NotImplementedException();
        }
    }
}
