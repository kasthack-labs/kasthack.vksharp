using System;

namespace VKSharp.Data.Api {
    [Flags]
    public enum VKPermission {
        Ads = 1<<1,
        Audio = 1 << 2,
        Docs = 1 << 3,
        Friends = 1 << 4,
        Groups = 1 << 5,
        Messages = 1 << 6,
        Nohttps = 1 << 7,
        Notes = 1 << 8,
        Notifications = 1 << 9,
        Notify = 1 << 10,
        Offers = 1 << 11,
        Offline = 1 << 12,
        Pages = 1 << 13,
        Photos = 1 << 14,
        Questions = 1 << 15,
        Stats = 1 << 16,
        Status = 1 << 17,
        Video = 1 << 18,
        Wall = 1 << 19,
        Everything = ~0,
        None = 0
    }
}