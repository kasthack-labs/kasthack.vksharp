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
        public async Task<User[]> UsersGetAsync( UserFields fields = UserFields.None, NameCase nameCase = NameCase.Nom, params uint[] ids ) {
            var req = new VKRequest<User> {
                MethodName = "users.get",
                Parameters = new Dictionary<string, string> {
                    { "fields", String.Join(",",String.Join(",",MiscTools.GetUserFields(fields)))},
                    { "user_ids", String.Join( ",", ids ) },
                    { "name_case", nameCase.ToNCLString() }
                },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            var resp = await this._executor.ExecAsync( req );
            return resp.Data;
        }

        public async Task<EntityList<User>> UsersGetFollowersAsync(
            uint userID,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<EntityList<User>> {
                MethodName = "users.getFollowers",
                Parameters = new Dictionary<string, string> {
                    { "fields", String.Join(",",MiscTools.GetUserFields(fields)) },
                    { "user_id", userID.ToNCString() },
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() },
                    { "name_case", nameCase.ToNCLString() }
                },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            var resp = await this._executor.ExecAsync( req );
            return resp.Data.First();
        }

        public async Task<User[]> UsersSearchAsync(
            string query = "",
            SearchSortOrder sort = SearchSortOrder.ByRating,
            ushort? offset = null,
            ushort? count = null,
            UserFields fields = UserFields.None,
            uint? cityID = null,
            uint? countryID = null,
            string hometown = "",
            uint? universityCountryID = null,
            uint? universityID = null,
            uint? universityYear = null,
            Sex? sex = null,
            Relation? relation = null,
            byte? ageFrom = null,
            byte? ageTo = null,
            byte? birthDay = null,
            byte? birthMonth = null,
            ushort? birthYear = null,
            bool? online = null,
            bool? hasPhoto = null,
            uint? schoolCountryID = null,
            uint? schoolCityID = null,
            uint? schoolID = null,
            uint? schoolYear = null,
            string religion = "",
            string interests = "",
            string company = "",
            string position = "",
            uint? groupID = null
            ) {
            var req = new VKRequest<User> {
                MethodName = "users.search",
                Parameters = {
                    { "q", query },
                    { "sort", sort.ToString().ToLowerInvariant() },
                    { "offset", MiscTools.NullableString(offset) },
                    { "count", MiscTools.NullableString(count) },
                    { "fields", String.Join(",",MiscTools.GetUserFields(fields)) },
                    { "city", MiscTools.NullableString(cityID) },
                    { "country", MiscTools.NullableString(countryID) },
                    { "hometown", hometown },
                    { "university_country", MiscTools.NullableString(universityCountryID) },
                    { "university", MiscTools.NullableString(universityID) },
                    { "university_year", MiscTools.NullableString(universityYear) },
                    { "sex", MiscTools.NullableString(sex) },
                    { "status", MiscTools.NullableString(relation) },
                    { "age_from", MiscTools.NullableString(ageFrom) },
                    { "age_to", MiscTools.NullableString(ageTo) },
                    { "birth_day", MiscTools.NullableString(birthDay) },
                    { "birth_month", MiscTools.NullableString(birthMonth) },
                    { "birth_year", MiscTools.NullableString(birthYear) },
                    { "online", MiscTools.NullableString(online.HasValue?(uint?)(online.Value?1:0):null) },
                    { "has_photo", MiscTools.NullableString(hasPhoto.HasValue?(uint?)(hasPhoto.Value?1:0):null)  },
                    { "school_country", MiscTools.NullableString(schoolCountryID) }, 
                    { "school_city", MiscTools.NullableString(schoolCityID) }, 
                    { "school", MiscTools.NullableString(schoolID) }, 
                    { "school_year", MiscTools.NullableString(schoolYear) }, 
                    { "religion", religion }, 
                    { "interests", interests }, 
                    { "company", company }, 
                    { "position", position },
                    { "group_id", MiscTools.NullableString(groupID)}
                },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            return ( await this._executor.ExecAsync( req ) ).Data;
        }

        public async Task<StructEntity<bool>> UserIsAppUserAsync( uint? userID ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "users.isAppUser",
                //fucking magic! i don't know why standard initializer doesn't work here
                Parameters = new Dictionary<string, string> { { "user_id", MiscTools.NullableString( userID ) } },
                Token = this.IsLogged ? this.CurrenToken : null
            };

            return ( await this._executor.ExecAsync( req ) ).Data[ 0 ];
        }
    }
}