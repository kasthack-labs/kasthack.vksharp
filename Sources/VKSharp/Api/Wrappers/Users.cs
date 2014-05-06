using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public User[] UsersGet(
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom,
            params uint[] ids) {
            return Helper.SyncTask(this.UsersGetAsync(fields, nameCase, ids));
        }
        public EntityList<User> UsersGetFollowers(uint userId,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.None,
            NameCase nameCase = NameCase.Nom) {
            return Helper.SyncTask(this.UsersGetFollowersAsync(userId, offset, count, fields, nameCase));
        }

        public StructEntity<bool> UserIsAppUser(uint? userId) {
            return Helper.SyncTask(this.UserIsAppUserAsync(userId));
        }

        public User[] UsersSearch(
            string query = "",
            SearchSortOrder sort = SearchSortOrder.ByRating,
            ushort? offset = null,
            ushort? count = null,
            UserFields fields = UserFields.None,
            uint? cityId = null,
            uint? countryId = null,
            string hometown = "",
            uint? universityCountryId = null,
            uint? universityId = null,
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
            uint? schoolCountryId = null,
            uint? schoolCityId = null,
            uint? schoolId = null,
            uint? schoolYear = null,
            string religion = "",
            string interests = "",
            string company = "",
            string position = "",
            uint? groupId = null) {
            return
                Helper.SyncTask(
                    this.UsersSearchAsync(
                        query,
                        sort,
                        offset,
                        count,
                        fields,
                        cityId,
                        countryId,
                        hometown,
                        universityCountryId,
                        universityId,
                        universityYear,
                        sex,
                        relation,
                        ageFrom,
                        ageTo,
                        birthDay,
                        birthMonth,
                        birthYear,
                        online,
                        hasPhoto,
                        schoolCountryId,
                        schoolCityId,
                        schoolId,
                        schoolYear,
                        religion,
                        interests,
                        company,
                        position,
                        groupId));
        }

        public StructEntity<bool> UsersReport(uint id, ComplaintType type, string comment) {
            return Helper.SyncTask(this.UsersReportAsync(id, type, comment));
        }
    }
}
