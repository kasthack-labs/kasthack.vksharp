using VKSharp.Data.Api;
using VKSharp.Data.Executors;

namespace VKSharp {
    public partial class VKApi {
        protected IExecutor _executor = new JsonExecutor();
        private readonly RequestApi _reqapi = new RequestApi();
        public IExecutor Executor => _executor;
        protected uint ReqCounter => _reqapi.ReqCounter;

        public VKToken CurrentToken => _reqapi.CurrentToken;
        public int TokenCount => _reqapi.TokenCount;

        public void AddToken( VKToken token ) => _reqapi.AddToken( token );

        public bool IsLogged {
            get { return _reqapi.IsLogged; }
            protected set{ _reqapi.IsLogged = value ; }
        }

        public VKApi() {
            InitializeMethodGroups();
        }

        public RawApi GetRawApi() => new RawApi( _reqapi, Executor );
    }
}
