using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Data.Parameters;
using VKSharp.Data.Request;
using VKSharp.Helpers.Api;

namespace VKSharp {
    public class VKApi {
        #region Vars
        private uint _reqCounter;
        private List<VKToken> _tokens = new List<VKToken>(); //tokens
        #endregion

        #region Properties & propfuncs
        private uint ReqCounter {
            get {
                return _reqCounter++;
            }
        }

        private VKToken CurrenToken {
            get {
                return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];
            }
        }

        public void AddToken( VKToken token ) {
            _tokens.Add( token );
            IsLogged = true;
        }

        public bool IsLogged { get; private set; }

        #endregion

        #region Constructors
        public VKApi() { }
        #endregion

        #region Public functions
        public async Task<User[]> usersGetAsync( uint ids, UserFields fields = UserFields.First_Name|UserFields.Last_Name, NameCase nameCase = NameCase.Nom ) {
            var Req = new VKRequest<User>() {
                MethodName = "users.get",
                Parameters = new Dictionary<string, string>() {
                    {
                        "fields",
                        String.Join(
                            ",",
                            Enum.GetValues(typeof(UserFields))
                                .OfType<UserFields>()
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
                Token = this.IsLogged?this.GetToken():null
            };
            var Resp = await this.Executor.ExecAsync(Req);
            return Resp.Data;
            //this.
        }
        #endregion

        #region Engine
        private VKToken GetToken() {
            if ( _tokens.Count == 0 )
                throw new InvalidOperationException( "User must be authorized for requesting this method" );
            return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];
        }
        #endregion
    }
}
