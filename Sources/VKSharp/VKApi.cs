using System;
using System.Collections.Generic;
using VKSharp.Data.Api;
using VKSharp.Data.Executors;

namespace VKSharp {
    public partial class VKApi {
        #region Vars
        private uint _reqCounter;
        private readonly List<VKToken> _tokens = new List<VKToken>(); //tokens
        protected IExecutor _executor = new SimpleXMLExecutor();
        private readonly RequestApi _reqapi = new RequestApi();

        public IExecutor Executor {
            get { return _executor; }
        } 

        #endregion

        #region Properties & propfuncs
        protected uint ReqCounter
        {
            get {
                return _reqCounter++;
            }
        }

        protected VKToken CurrenToken
        {
            get {
                if ( _tokens.Count == 0 )
                    throw new InvalidOperationException("This method requires auth!");
                return _tokens[ (int) ( ReqCounter % _tokens.Count ) ];
            }
        }

        public void AddToken( VKToken token ) {
            _tokens.Add( token );
            IsLogged = true;
        }

        public bool IsLogged {
            get {
                return _reqapi.IsLogged;
            }
            protected set{
                _reqapi.IsLogged = value ;
            }
        }

        #endregion
    }
}
