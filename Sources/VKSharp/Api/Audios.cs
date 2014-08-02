using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<Audio[]> AudioGetByIdAsync( IEnumerable<Tuple<int, int>> audios, bool itunes = false ) {
            return await AudioGetByIdAsync(itunes, audios.Select(a => a.Item1 + "_" + a.Item2).ToArray());
        }
        public async Task<EntityList<Audio>> AudioSearchAsync( string q, bool autoComplete=true, bool lyrics=false,
            bool performerOnly=false, AudioSortOrder sort = AudioSortOrder.ByRating, bool searchOwn = false,
            int offset=0, int? count = null) {
            var req = new VKRequest<EntityList<Audio>> {
                MethodName = "audio.search",
                Parameters = new Dictionary<string, string> {
                    { "q",q},
                    { "auto_complete",(autoComplete?1:0).ToNCString()},
                    { "lyrics",(lyrics?1:0).ToNCString()},
                    { "performer_only",(searchOwn?1:0).ToNCString()},
                    { "search_own",(performerOnly?1:0).ToNCString()},
                    { "offset", offset.ToNCString() },
                    { "count", MiscTools.NullableString( count ) },
                    { "sort",((int)sort).ToNCString()}
                }
            };
            if (IsLogged)
                req.Token = CurrenToken;
            return (await _executor.ExecAsync(req)).Data.FirstOrDefault();
        }
    }
}