using VKSharp.Core.Enums;

namespace VKSharp.Data.Parameters {
    public class UsersSearchParams {
        public UsersSearchParams( string query = "", SearchSortOrder sort = SearchSortOrder.ByRating,
                                  ushort? offset = null, ushort? count = null, UserFields fields = UserFields.None,
                                  int? cityId = null, int? countryId = null, string hometown = "", int? universityCountryId = null,
                                  int? universityId = null, int? universityYear = null, Sex? sex = null, Relation? relation = null,
                                  byte? ageFrom = null, byte? ageTo = null, byte? birthDay = null, byte? birthMonth = null,
                                  ushort? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountryId = null,
                                  int? schoolCityId = null, int? schoolId = null, int? schoolYear = null, string religion = "",
                                  string interests = "", string company = "", string position = "", int? groupId = null ) {
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

        public int? CityId { get; }

        public int? CountryId { get; }

        public string Hometown { get; }

        public int? UniversityCountryId { get; }

        public int? UniversityId { get; }

        public int? UniversityYear { get; }

        public Sex? Sex { get; }

        public Relation? Relation { get; }

        public byte? AgeFrom { get; }

        public byte? AgeTo { get; }

        public byte? BirthDay { get; }

        public byte? BirthMonth { get; }

        public ushort? BirthYear { get; }

        public bool? Online { get; }

        public bool? HasPhoto { get; }

        public int? SchoolCountryId { get; }

        public int? SchoolCityId { get; }

        public int? SchoolId { get; }

        public int? SchoolYear { get; }

        public string Religion { get; }

        public string Interests { get; }

        public string Company { get; }

        public string Position { get; }

        public int? GroupId { get; }
    }
}