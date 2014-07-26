using System;
using System.Collections.Generic;
using VKSharp.Data.Api;
using VKSharp.Data.Executors;

namespace VKSharp {
    public partial class VKApi {
        #region Vars
        protected uint _reqCounter;
        protected readonly List<VKToken> _tokens = new List<VKToken>(); //tokens
        protected readonly IExecutor _executor = new SimpleXMLExecutor();

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
    }
}
