using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<EntityList<Post>> WallGetAsync (int? ownerId, string domain = "",
            int offset = 0, int count = 100, WallPostFilter filter = WallPostFilter.All) {
            var req = new VKRequest<EntityList<Post>> {
                MethodName = "wall.get",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", MiscTools.NullableString( ownerId ) },
                    { "domain", domain },
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() },
                    { "filter", filter.ToNClString().ToSnake() }
                }
            };
            if ( IsLogged ) req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<Post[]> WallGetByIdAsync(int copyHistoryDepth = 2, params Tuple<int,uint>[] ids ){
            return await WallGetByIdAsync( copyHistoryDepth, ids.Select( a => a.Item1.ToNCString() + "_" + a.Item2.ToNCString() ).ToArray() );
        }
        public async Task<Post[]> WallGetByIdAsync(int copyHistoryDepth = 2, params string[] ids){
            var req = new VKRequest<Post> {
                MethodName = "wall.getById",
                Parameters = new Dictionary<string, string> {
                    { "posts", String.Join(",", ids) },
                    { "copy_history_depth", copyHistoryDepth.ToNCString() }
                }
            };
            if ( IsLogged ) req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data;
        }
    }
}