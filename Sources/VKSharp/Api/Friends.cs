
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
        public async Task<User[]> FriendsGetAsync(
           uint userID,
           UserSortOrder order = UserSortOrder.ByID,
           uint? listID = null,
           uint offset = 0,
           ushort count = 100,
           UserFields fields = UserFields.First_Name | UserFields.Last_Name,
           NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<User> {
                MethodName = "friends.get",
                Parameters = new Dictionary<string, string> {
                    {
                        "fields",
                        String.Join(
                            ",",
                            Enum.GetValues(typeof(UserFields))
                                .OfType<UserFields>()
                                .Where(a=>a!=UserFields.Everything)
                                .Where(a=>fields.HasFlag(a))
                                .Select(a=>a.ToString().ToLowerInvariant())
                                .ToArray()
                        )
                    },
                    {
                        "list_id",
                        listID.HasValue?listID.ToString().ToLowerInvariant():""
                    },
                    {
                        "order",
                        order==UserSortOrder.ByID?"":order.ToString().ToLowerInvariant()
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
            return resp.Data;
        }
    }
}