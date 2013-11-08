using System;

namespace VKSharp.Data.Parameters {
    [Flags]
    public enum FriendSuggestionFilters {
        Mutual=1<<1,
        Contacts=1<<2,
        Mutual_Contacts = 1 << 3,
        Everything=~0
    }
}
