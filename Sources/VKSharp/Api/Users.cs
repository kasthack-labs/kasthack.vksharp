using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<UserSubscriptions> UserGetSubscriptionsAsync(
            uint? userId = null, int offset=0, int? count=null) {
            var req = new VKRequest<UserSubscriptions> {
                MethodName = "users.getSubscriptions",
                Parameters = new Dictionary<string, string> {
                    { "user_id", MiscTools.NullableString(userId) },
                    { "offset", offset.ToNCString() },
                    {"count", MiscTools.NullableString( count )}
                },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> UserIsAppUserAsync( uint? userId = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "users.isAppUser",
                Parameters = new Dictionary<string, string> { { "user_id", MiscTools.NullableString( userId ) } },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            return ( await this._executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<User[]> UsersGetAsync( UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom, params uint[] ids ) {
            var req = new VKRequest<User> {
                MethodName = "users.get",
                Parameters =
                    new Dictionary<string, string> {
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields ) ) },
                        { "user_ids", ids.ToNCStringA() },
                        { "name_case", nameCase.ToNClString() }
                    },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            var resp = await this._executor.ExecAsync( req );
            return resp.Data;
        }

        public async Task<EntityList<User>> UsersGetFollowersAsync(
            uint userId, uint offset = 0, ushort count = 100,
            UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<EntityList<User>> {
                MethodName = "users.getFollowers",
                Parameters =
                    new Dictionary<string, string> {
                        { "fields", String.Join( ",", MiscTools.GetUserFields( fields )) },
                        { "user_id", userId.ToNCString() },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() },
                        { "name_case", nameCase.ToNClString() }
                    },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            var resp = await this._executor.ExecAsync( req );
            return resp.Data.First();
        }

        public async Task UsersReportAsync( uint id, ComplaintType type, string comment ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "users.report",
                Parameters =
                    new Dictionary<string, string> {
                        { "user_id", id.ToNCString() },
                        { "type", type.ToNClString() },
                        { "comment", comment }
                    },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            await this._executor.ExecAsync(req);
        }

        public async Task<User[]> UsersSearchAsync( UsersSearchParams usersSearchParams ) {
            var req = new VKRequest<User> {
                MethodName = "users.search",
                Parameters =
                    new Dictionary<string, string> {
                        { "q", usersSearchParams.Query },
                        { "sort", ( (int) usersSearchParams.Sort ).ToNCString() },
                        { "offset", MiscTools.NullableString( usersSearchParams.Offset ) },
                        { "count", MiscTools.NullableString( usersSearchParams.Count ) },
                        { "fields", String.Join( ",", MiscTools.GetUserFields( usersSearchParams.Fields ) ) },
                        { "city", MiscTools.NullableString( usersSearchParams.CityId ) },
                        { "country", MiscTools.NullableString( usersSearchParams.CountryId ) },
                        { "hometown", usersSearchParams.Hometown },
                        { "university_country", MiscTools.NullableString( usersSearchParams.UniversityCountryId ) },
                        { "university", MiscTools.NullableString( usersSearchParams.UniversityId ) },
                        { "university_year", MiscTools.NullableString( usersSearchParams.UniversityYear ) },
                        { "sex", usersSearchParams.Sex != null ? ( (int) usersSearchParams.Sex ).ToNCString() : "" },
                        { "status", MiscTools.NullableString( usersSearchParams.Relation ) },
                        { "age_from", MiscTools.NullableString( usersSearchParams.AgeFrom ) },
                        { "age_to", MiscTools.NullableString( usersSearchParams.AgeTo ) },
                        { "birth_day", MiscTools.NullableString( usersSearchParams.BirthDay ) },
                        { "birth_month", MiscTools.NullableString( usersSearchParams.BirthMonth ) },
                        { "birth_year", MiscTools.NullableString( usersSearchParams.BirthYear ) },
                        { "online", MiscTools.NullableString( usersSearchParams.Online.HasValue ? (uint?) ( usersSearchParams.Online.Value ? 1 : 0 ) : null ) },
                        { "has_photo", MiscTools.NullableString( usersSearchParams.HasPhoto.HasValue ? (uint?) ( usersSearchParams.HasPhoto.Value ? 1 : 0 ) : null ) },
                        { "school_country", MiscTools.NullableString( usersSearchParams.SchoolCountryId ) },
                        { "school_city", MiscTools.NullableString( usersSearchParams.SchoolCityId ) },
                        { "school", MiscTools.NullableString( usersSearchParams.SchoolId ) },
                        { "school_year", MiscTools.NullableString( usersSearchParams.SchoolYear ) },
                        { "religion", usersSearchParams.Religion },
                        { "interests", usersSearchParams.Interests },
                        { "company", usersSearchParams.Company },
                        { "position", usersSearchParams.Position },
                        { "group_id", MiscTools.NullableString( usersSearchParams.GroupId ) }
                    },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            return ( await this._executor.ExecAsync( req ) ).Data;
        }

        //TODO: extended view is not supported
    }
}