using System;

namespace VKSharp.Data.Parameters {
    [Flags]
    /*
     * DON'T RENAME!
     * Names are used in users.get method and extracted with reflection
     */
    public enum UserFields:ulong {
        About = 1UL << 1,
        Activity = 1UL << 2,
        Bdate = 1UL << 3,
        Books = 1UL << 4,
        // ReSharper disable once InconsistentNaming
        Can_Post = 1UL << 5,
        // ReSharper disable once InconsistentNaming
        Can_See_All_Posts = 1UL << 6,
        // ReSharper disable once InconsistentNaming
        Can_See_Audio = 1UL << 7,
        // ReSharper disable once InconsistentNaming
        Can_Write_Private_Message = 1UL << 8,
        City = 1UL << 9,
        Connections = 1UL << 10,
        Contacts = 1UL << 11,
        Counters = 1UL << 12,
        Country = 1UL << 13,
        Education = 1UL << 14,
        // ReSharper disable once InconsistentNaming
        First_Name = 1UL << 15,
        Games = 1UL << 16,
        // ReSharper disable once InconsistentNaming
        Has_Mobile = 1UL << 17,
        Interests = 1UL << 18,
        // ReSharper disable once InconsistentNaming
        Last_Name = 1UL << 19,
        // ReSharper disable once InconsistentNaming
        Last_Seen = 1UL << 20,
        Movies = 1UL << 21,
        Nickname = 1UL << 22,
        Online = 1UL << 23,
        // ReSharper disable once InconsistentNaming
        Photo_100 = 1UL << 24,
        // ReSharper disable once InconsistentNaming
        Photo_200 = 1UL << 25,
        // ReSharper disable once InconsistentNaming
        Photo_200_orig = 1UL << 26,
        // ReSharper disable once InconsistentNaming
        Photo_400_orig = 1UL << 27,
        // ReSharper disable once InconsistentNaming
        Photo_50 = 1UL << 28,
        // ReSharper disable once InconsistentNaming
        Photo_Max = 1UL << 29,
        // ReSharper disable once InconsistentNaming
        Photo_Max_Orig = 1UL << 30,
        Rating = 1UL << 31,
        Relation = 1UL << 32,
        Relatives = 1UL << 33,
        Schools = 1UL << 34,
        // ReSharper disable once InconsistentNaming
        Screen_Name = 1UL << 35,
        Sex = 1UL << 36,
        Status = 1UL << 37,
        Timezone = 1UL << 38,
        Tv = 1UL << 39,
        Universities = 1UL << 40,
        Verified = 1UL << 41,
        // ReSharper disable once InconsistentNaming
        Wall_Comments = 1UL << 42,
        Everything = ~0UL
    }
}
