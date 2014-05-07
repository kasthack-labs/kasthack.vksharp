using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> StorageSetAsync( string key,
                                                               string value,
                                                               uint? userId,
                                                               bool global = false ) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "storage.set",
                Parameters = new Dictionary<string, string> {
                    {
                        "key", key
                    }, {
                        "value", value
                    }, {
                        "user_id", MiscTools.NullableString( userId )
                    }, {
                        "global", ( global ? 1 : 0 ).ToNCString()
                    }
                }
            };
            if ( this.IsLogged )
                req.Token = this.CurrenToken;
            return ( await this.Executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StorageEntry[]> StorageGetAsync( uint? userId,
                                                           bool global = false,
                                                           params string[] keys ) {
            var req = new VKRequest<StorageEntry> {
                MethodName = "storage.get",
                Parameters = new Dictionary<string, string> {
                    { "keys", string.Join( ",", keys ) },
                    { "user_id", MiscTools.NullableString( userId ) },
                    { "global", ( global ? 1 : 0 ).ToNCString() }
                }
            };
            if (this.IsLogged)
                req.Token = this.CurrenToken;
            return ( await this.Executor.ExecAsync( req ) ).Data;
        }
        public async Task<SimpleEntity<string>[]> StorageGetKeysAsync(uint? userId,
                                                           bool global = false,
                                                           uint offset=0,
                                                           uint count=100) {
            var req = new VKRequest<SimpleEntity<string>> {
                MethodName = "storage.getKeys",
                Parameters = new Dictionary<string, string> {
                    { "user_id", MiscTools.NullableString( userId ) },
                    { "global", ( global ? 1 : 0 ).ToNCString() },
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() },
                }
            };
            if (this.IsLogged)
                req.Token = this.CurrenToken;
            return (await this.Executor.ExecAsync(req)).Data;
        }
    }
}