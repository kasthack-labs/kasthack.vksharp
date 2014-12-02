using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp {
    public partial class VKApi {
        //public async Task<User[]> UsersSearchAsync( UsersSearchParams usersSearchParams ) {
        //    var req = new VKRequest<User[]> {
        //        MethodName = "users.search",
        //        Parameters =
        //            new Dictionary<string, string> {
        //                { "q", usersSearchParams.Query },
        //                { "sort", ( (int) usersSearchParams.Sort ).ToNCString() },
        //                { "offset", MiscTools.NullableString( usersSearchParams.Offset ) },
        //                { "count", MiscTools.NullableString( usersSearchParams.Count ) },
        //                { "fields", String.Join( ",", MiscTools.GetUserFields( usersSearchParams.Fields ) ) },
        //                { "city", MiscTools.NullableString( usersSearchParams.CityId ) },
        //                { "country", MiscTools.NullableString( usersSearchParams.CountryId ) },
        //                { "hometown", usersSearchParams.Hometown },
        //                { "university_country", MiscTools.NullableString( usersSearchParams.UniversityCountryId ) },
        //                { "university", MiscTools.NullableString( usersSearchParams.UniversityId ) },
        //                { "university_year", MiscTools.NullableString( usersSearchParams.UniversityYear ) },
        //                { "sex", usersSearchParams.Sex != null ? ( (int) usersSearchParams.Sex ).ToNCString() : "" },
        //                { "status", MiscTools.NullableString( usersSearchParams.Relation ) },
        //                { "age_from", MiscTools.NullableString( usersSearchParams.AgeFrom ) },
        //                { "age_to", MiscTools.NullableString( usersSearchParams.AgeTo ) },
        //                { "birth_day", MiscTools.NullableString( usersSearchParams.BirthDay ) },
        //                { "birth_month", MiscTools.NullableString( usersSearchParams.BirthMonth ) },
        //                { "birth_year", MiscTools.NullableString( usersSearchParams.BirthYear ) },
        //                { "online", MiscTools.NullableString( usersSearchParams.Online.HasValue ? (uint?) ( usersSearchParams.Online.Value ? 1 : 0 ) : null ) },
        //                { "has_photo", MiscTools.NullableString( usersSearchParams.HasPhoto.HasValue ? (uint?) ( usersSearchParams.HasPhoto.Value ? 1 : 0 ) : null ) },
        //                { "school_country", MiscTools.NullableString( usersSearchParams.SchoolCountryId ) },
        //                { "school_city", MiscTools.NullableString( usersSearchParams.SchoolCityId ) },
        //                { "school", MiscTools.NullableString( usersSearchParams.SchoolId ) },
        //                { "school_year", MiscTools.NullableString( usersSearchParams.SchoolYear ) },
        //                { "religion", usersSearchParams.Religion },
        //                { "interests", usersSearchParams.Interests },
        //                { "company", usersSearchParams.Company },
        //                { "position", usersSearchParams.Position },
        //                { "group_id", MiscTools.NullableString( usersSearchParams.GroupId ) }
        //            },
        //        Token = IsLogged ? CurrentToken : null
        //    };
        //    return ( await _executor.ExecAsync( req ) ).Data;
        //}

        //TODO: extended view is not supported
    }
}