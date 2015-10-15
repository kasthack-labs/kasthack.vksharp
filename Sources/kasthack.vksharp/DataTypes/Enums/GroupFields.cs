using System;

namespace kasthack.vksharp.DataTypes.Enums {
    [Flags]
    public enum GroupFields {
        City=1,
        Country=1<<1,
        Place=1<<2,
        Description=1<<3,
        WikiPage=1<<4,
        MembersCount=1<<5,
        Counters=1<<6,
        StartDate=1<<7,
        Finish_date,
        CanPost,
        CanSeeAllPosts,
        Activity,
        Status,
        Contacts,
        Links,
        FixedPost,
        Verified,
        Site,
        Everything=~0,
        None = 0
    }
}
