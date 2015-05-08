using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKSharp.Core.ResponseEntities
{
    public class FriendsDeleteResponse
    {
        public bool Success { get; set; }
        public bool FriendDeleted { get; set; }
        public bool OutRequestDeleted { get; set; }
        public bool InRequestDeleted { get; set; }
        public bool SuggestionDeleted { get; set; }
    }
}
