using kasthack.vksharp;
using kasthack.vksharp.Implementation;

namespace kasthack.vksharp {
    public partial class Api {
        protected IExecutor _executor;
        private readonly RequestApi _reqapi = new RequestApi();
        public IExecutor Executor => _executor;
        protected uint ReqCounter => _reqapi.ReqCounter;

        public Token CurrentToken => _reqapi.CurrentToken;
        public int TokenCount => _reqapi.TokenCount;

        public void AddToken( Token token ) => _reqapi.AddToken( token );

        public bool IsLogged {
            get { return _reqapi.IsLogged; }
            protected set{ _reqapi.IsLogged = value ; }
        }

        public Api() : this(new JsonExecutor()) {
        }

        public Api( IExecutor executor ) {
            InitializeMethodGroups();
            _executor = executor;
        }

        public RawApi GetRawApi() => new RawApi( _reqapi, Executor );
    }
}
