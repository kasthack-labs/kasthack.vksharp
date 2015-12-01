using System;

namespace kasthack.vksharp.DataTypes.Enums {
    [Flags]
    //DO NOT RENAME!
    public enum FriendSuggestionFilters {
        Mutual=1<<1,
        Contacts=1<<2,
        MutualContacts = 1 << 3,
        Everything=~0
    }
}
