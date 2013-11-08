using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp {
    public partial class VKApi {
        public async Task<User[]> UsersGetAsync( IEnumerable<uint> ids, UserFields fields = UserFields.First_Name|UserFields.Last_Name, NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<User> {
                MethodName = "users.get",
                Parameters = new Dictionary<string, string> {
                    {
                        "fields",
                        String.Join(
                            ",",
                            String.Join(",",MiscTools.GetUserFields(fields))
                        )
                    },
                    {
                        "user_ids",
                        String.Join(
                            ",",
                            ids
                        )
                    },
                    {
                        "name_case",
                        nameCase.ToString().ToLowerInvariant()
                    }
                },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            var resp = await this._executor.ExecAsync( req );
            return resp.Data;
        }

        public async Task<EntityList<User>> UsersGetFollowersAsync(
            uint userID,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<EntityList<User>> {
                MethodName = "users.getFollowers",
                Parameters = new Dictionary<string, string> {
                    {
                        "fields",
                        String.Join(",",MiscTools.GetUserFields(fields))
                    },
                    {
                        "user_id",
                        userID.ToString(BuiltInData.Instance.NC)
                    },
                    {
                        "offset",
                        offset.ToString(BuiltInData.Instance.NC)
                    },
                    {
                        "count",
                        count.ToString(BuiltInData.Instance.NC)
                    },
                    {
                        "name_case",
                        nameCase.ToString().ToLowerInvariant()
                    }
                },
                Token = this.IsLogged ? this.CurrenToken : null
            };
            var resp = await this._executor.ExecAsync( req );
            return resp.Data.First();
        }

    }
}