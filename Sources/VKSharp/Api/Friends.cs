
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
                        String.Join(",",MiscTools.GetUserFields(fields))
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

        public async Task<User[]> FriendsGetByPhonesAsync(
           IEnumerable<ulong> phones,
           UserFields fields = UserFields.First_Name | UserFields.Last_Name ) {
            var req = new VKRequest<User> {
                MethodName = "friends.get",
                Parameters = new Dictionary<string, string> {
                    {
                        "fields",
                        String.Join(",",MiscTools.GetUserFields(fields))
                    },
                    {
                        "phones",
                        String.Join(
                            ",",
                            phones.Select(a=>"+"+a)
                        )
                    }
                }
            };
            if ( !this.IsLogged )
                throw new InvalidOperationException( "This method requires auth!" );
            req.Token = this.CurrenToken;
            var resp = await this._executor.ExecAsync( req );
            return resp.Data;
        }

        public async Task<User[]> FriendsGetSuggestionsAsync(
            FriendSuggestionFilters filters = FriendSuggestionFilters.Everything,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<User> {
                MethodName = "friends.get",
                Parameters = new Dictionary<string, string> {
                    {
                        "fields",
                        String.Join(",",MiscTools.GetUserFields(fields))
                    },
                    {
                        "filters",
                        String.Join(",",MiscTools.GetFilterFields(filters))
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