using VKSharp.Core.Enums;

namespace VKSharp.Data.Parameters {
    public class UsersSearchParams {
        public UsersSearchParams( string query = "", SearchSortOrder sort = SearchSortOrder.ByRating,
                                  ushort? offset = null, ushort? count = null, UserFields fields = UserFields.None,
                                  uint? cityId = null, uint? countryId = null, string hometown = "", uint? universityCountryId = null,
                                  uint? universityId = null, uint? universityYear = null, Sex? sex = null, Relation? relation = null,
                                  byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null,
                                  ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, uint? schoolCountryId = null,
                                  uint? schoolCityId = null, uint? schoolId = null, uint? schoolYear = null, string religion = "",
                                  string interests = "", string company = "", string position = "", uint? groupId = null ) {
            Query = query;
            Sort = sort;
            Offset = offset;
            Count = count;
            Fields = fields;
            CityId = cityId;
            CountryId = countryId;
            Hometown = hometown;
            UniversityCountryId = universityCountryId;
            UniversityId = universityId;
            UniversityYear = universityYear;
            Sex = sex;
            Relation = relation;
            AgeFrom = ageFrom;
            AgeTo = ageTo;
            BirthDay = birthDay;
            BirthMonth = birthMonth;
            BirthYear = birthYear;
            Online = online;
            HasPhoto = hasPhoto;
            SchoolCountryId = schoolCountryId;
            SchoolCityId = schoolCityId;
            SchoolId = schoolId;
            SchoolYear = schoolYear;
            Religion = religion;
            Interests = interests;
            Company = company;
            Position = position;
            GroupId = groupId;
        }

        public string Query { get; }

        public SearchSortOrder Sort { get; }

        public ushort? Offset { get; }

        public ushort? Count { get; }

        public UserFields Fields { get; }

        public uint? CityId { get; }

        public uint? CountryId { get; }

        public string Hometown { get; }

        public uint? UniversityCountryId { get; }

        public uint? UniversityId { get; }

        public uint? UniversityYear { get; }

        public Sex? Sex { get; }

        public Relation? Relation { get; }

        public byte? AgeFrom { get; }

        public byte? AgeTo { get; }

        public byte? BirthDay { get; }

        public byte? BirthMonth { get; }

        public ushort? BirthYear { get; }

        public bool? Online { get; }

        public bool? HasPhoto { get; }

        public uint? SchoolCountryId { get; }

        public uint? SchoolCityId { get; }

        public uint? SchoolId { get; }

        public uint? SchoolYear { get; }

        public string Religion { get; }

        public string Interests { get; }

        public string Company { get; }

        public string Position { get; }

        public uint? GroupId { get; }
    }
}