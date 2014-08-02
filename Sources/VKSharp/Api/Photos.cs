using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.ResponseEntities;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<Photo[]> PhotosSaveAsync(long albumId, string server,  string photosList,string hash,
            uint? groupId = null,  double? latitude = null, double? longitude = null,
            string caption = "", string description = "") {
            var req = new VKRequest<Photo> {
                MethodName = "photos.save",
                Parameters = new Dictionary<string, string> {
                    {"album_id", albumId.ToNCString() },
                    {"server",server},
                    {"hash",hash},
                    {"group_id", MiscTools.NullableString( groupId )},
                    {"photos_list", photosList },
                    {"latitude", MiscTools.NullableString( latitude )},
                    {"longitude", MiscTools.NullableString( longitude )},
                    {"caption",caption},
                    {"description",description}
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data;
        }
    }
}