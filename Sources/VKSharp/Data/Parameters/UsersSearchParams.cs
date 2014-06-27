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
            this.Query = query;
            this.Sort = sort;
            this.Offset = offset;
            this.Count = count;
            this.Fields = fields;
            this.CityId = cityId;
            this.CountryId = countryId;
            this.Hometown = hometown;
            this.UniversityCountryId = universityCountryId;
            this.UniversityId = universityId;
            this.UniversityYear = universityYear;
            this.Sex = sex;
            this.Relation = relation;
            this.AgeFrom = ageFrom;
            this.AgeTo = ageTo;
            this.BirthDay = birthDay;
            this.BirthMonth = birthMonth;
            this.BirthYear = birthYear;
            this.Online = online;
            this.HasPhoto = hasPhoto;
            this.SchoolCountryId = schoolCountryId;
            this.SchoolCityId = schoolCityId;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
            this.Religion = religion;
            this.Interests = interests;
            this.Company = company;
            this.Position = position;
            this.GroupId = groupId;
        }

        public string Query { get; private set; }

        public SearchSortOrder Sort { get; private set; }

        public ushort? Offset { get; private set; }

        public ushort? Count { get; private set; }

        public UserFields Fields { get; private set; }

        public uint? CityId { get; private set; }

        public uint? CountryId { get; private set; }

        public string Hometown { get; private set; }

        public uint? UniversityCountryId { get; private set; }

        public uint? UniversityId { get; private set; }

        public uint? UniversityYear { get; private set; }

        public Sex? Sex { get; private set; }

        public Relation? Relation { get; private set; }

        public byte? AgeFrom { get; private set; }

        public byte? AgeTo { get; private set; }

        public byte? BirthDay { get; private set; }

        public byte? BirthMonth { get; private set; }

        public ushort? BirthYear { get; private set; }

        public bool? Online { get; private set; }

        public bool? HasPhoto { get; private set; }

        public uint? SchoolCountryId { get; private set; }

        public uint? SchoolCityId { get; private set; }

        public uint? SchoolId { get; private set; }

        public uint? SchoolYear { get; private set; }

        public string Religion { get; private set; }

        public string Interests { get; private set; }

        public string Company { get; private set; }

        public string Position { get; private set; }

        public uint? GroupId { get; private set; }
    }
}