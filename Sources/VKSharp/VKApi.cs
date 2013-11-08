using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpicMorg.Net;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Api;
using VKSharp.Data.Executors;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp {
    public class VKApi {
        #region Vars
        private uint _reqCounter;
        private readonly List<VKToken> _tokens = new List<VKToken>(); //tokens
        private readonly IExecutor _executor = new SimpleXMLExecutor();
        #endregion

        #region Properties & propfuncs
        private uint ReqCounter {
            get {
                return _reqCounter++;
            }
        }

        private VKToken CurrenToken {
            get {
                if ( _tokens.Count == 0 )
                    throw new InvalidOperationException( "User must be authorized for requesting this method" );
                return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];
            }
        }

        public void AddToken( VKToken token ) {
            _tokens.Add( token );
            IsLogged = true;
        }

        public bool IsLogged { get; private set; }

        #endregion

        #region Public functions
        public async Task<User[]> UsersGetAsync( IEnumerable<uint> ids, UserFields fields = UserFields.First_Name|UserFields.Last_Name, NameCase nameCase = NameCase.Nom ) {
            var req = new VKRequest<User> {
                MethodName = "users.get",
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
            //this.
        }

        public async Task<EntityList<User>> UsersGetFollowersAsync(
            uint userID,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom) {
                var req = new VKRequest<EntityList<User>> {
                MethodName = "users.getFollowers",
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
        #endregion
        
        #region Public fucntions synchronous wrappers
        public User[] UsersGet( IEnumerable<uint> ids, UserFields fields = UserFields.First_Name | UserFields.Last_Name, NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.UsersGetAsync( ids, fields, nameCase ) );
        }
        public EntityList<User> UsersGetFollowers( uint userID,
            uint offset = 0,
            ushort count = 100,
            UserFields fields = UserFields.First_Name | UserFields.Last_Name,
            NameCase nameCase = NameCase.Nom ) {
            return Helper.SyncTask( this.UsersGetFollowersAsync(userID, offset, count, fields, nameCase) );
        }
        #endregion
    }
}
