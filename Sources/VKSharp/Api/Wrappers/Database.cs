using EpicMorg.Net;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public EntityList<DatabaseEntry> DatabaseGetCountries(
            bool needAll = false,
            string code = "",
            uint offset = 0,
            uint count = 100 ) {
            return Helper.SyncTask( this.DatabaseGetCountriesAsync( needAll, code, offset, count ) );
        }
    }
}
