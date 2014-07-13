using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp {
    public partial class VKApi {
        public async Task<EntityList<DatabaseEntry>> DatabaseGetCountriesAsync(
            bool needAll = false, string code = "", uint offset = 0, uint count = 100 ) {
            var req = new VKRequest<EntityList<DatabaseEntry>> {
                MethodName = "database.getCountries",
                Parameters =
                    new Dictionary<string, string> {
                        { "need_all", ( needAll ? 1 : 0 ).ToNCString() },
                        { "code", code },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<EntityList<DatabaseEntry>> DatabaseGetRegionsAsync(
            uint country_id, string q = "", uint offset = 0, uint count = 100 ) {
            var req = new VKRequest<EntityList<DatabaseEntry>> {
                MethodName = "database.getRegions",
                Parameters =
                    new Dictionary<string, string> {
                        { "country_id", country_id.ToNCString() },
                        { "q", q },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<DatabaseEntry[]> DatabaseGetStreetsByIdAsync( params uint[] streetIds ) {
            var req = new VKRequest<DatabaseEntry> {
                MethodName = "database.getStreetsById",
                Parameters = new Dictionary<string, string> { { "street_ids", streetIds.ToNCStringA() } }
            };
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task<DatabaseEntry[]> DatabaseGetCountriesByIdAsync( params uint[] countryIds ) {
            var req = new VKRequest<DatabaseEntry> {
                MethodName = "database.getCountriesById",
                Parameters =
                    new Dictionary<string, string> { { "country_ids", countryIds.ToNCStringA() } }
            };
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task<DatabaseCity[]> DatabaseGetCitiesByIdAsync( params uint[] cityIds ) {
            var req = new VKRequest<DatabaseCity> {
                MethodName = "database.getCitiesById",
                Parameters = new Dictionary<string, string> { { "city_ids", cityIds.ToNCStringA() } }
            };
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task<DatabaseCity[]> DatabaseGetCitiesAsync( uint countryId, uint? regionId = null,
            string q = "", bool? needAll = null, uint offset = 0, uint count = 100 ) {
            var req = new VKRequest<DatabaseCity> {
                MethodName = "database.getCities",
                Parameters =
                    new Dictionary<string, string> {
                        { "country_id", countryId.ToNCString() },
                        { "region_id", MiscTools.NullableString( regionId ) },
                        { "q", q },
                        { "need_all", needAll != null ? ( needAll.Value ? 1 : 0 ).ToNCString() : "" },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task<DatabaseEntry[]> DatabaseGetUniversitiesAsync( uint? countryId = null,
            uint? cityId = null, string q = "", uint offset = 0, uint count = 100 ) {
            var req = new VKRequest<DatabaseEntry> {
                MethodName = "database.getUniversities",
                Parameters =
                    new Dictionary<string, string> {
                        { "country_id", MiscTools.NullableString( countryId ) },
                        { "city_id", MiscTools.NullableString( cityId ) },
                        { "q", q },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task<DatabaseEntry[]> DatabaseGetSchoolsAsync( uint? cityId = null,
            string q = "", uint offset = 0, uint count =100 ) {
            var req = new VKRequest<DatabaseEntry> {
                MethodName = "database.getSchools",
                Parameters =
                    new Dictionary<string, string> {
                        { "city_id", MiscTools.NullableString( cityId ) },
                        { "q", q },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return ( await _executor.ExecAsync( req ) ).Data;
        }
        public async Task<EntityList<DatabaseEntry>> DatabaseGetFacultiesAsync(
            uint universityId, uint offset = 0, uint count = 100 ) {
                var req = new VKRequest<EntityList<DatabaseEntry>> {
                MethodName = "database.getFaculties",
                Parameters =
                    new Dictionary<string, string> {
                        { "university_id", universityId.ToNCString() },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<EntityList<DatabaseEntry>> DatabaseGetChairsAsync(
            uint facultyId, uint offset = 0, uint count = 100 ) {
            var req = new VKRequest<EntityList<DatabaseEntry>> {
                MethodName = "database.getChairs",
                Parameters =
                    new Dictionary<string, string> {
                        { "faculty_id", facultyId.ToNCString() },
                        { "offset", offset.ToNCString() },
                        { "count", count.ToNCString() }
                    }
            };
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}