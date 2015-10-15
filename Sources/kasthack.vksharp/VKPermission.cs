using System;

namespace kasthack.vksharp {
    [Flags]
    public enum Permission {
        Ads = 32768,
        Audio = 8,
        Docs = 131072,
        Email = 4194304,
        Friends = 2,
        Groups= 262144,
        Messages = 4096,
        //Nohttps = 1 << 7,
        //fuck nohttps
        Menu= 256,
        Notes = 2048,
        Notifications = 524288,
        Notify = 1,
        Offers = 32,
        Offline = 65536,
        Pages = 128,
        Photos = 4,
        Questions = 64,
        Stats = 1048576,
        Status = 1024,
        Video = 16,
        Wall = 8192,
        Everything = ~0,
        None = 0
    }
}