using VKSharp.Data.Api;
using VKSharp.Data.Executors;

namespace VKSharp {
    public partial class RawApi {

        protected IExecutor _executor = new SimpleXMLExecutor();
        private readonly RequestApi _reqapi = new RequestApi();
        public IExecutor Executor => _executor;
        protected uint ReqCounter => _reqapi.ReqCounter;

        protected VKToken CurrentToken => _reqapi.CurrentToken;

        public void AddToken( VKToken token ) => _reqapi.AddToken( token );

        public bool IsLogged {
            get { return _reqapi.IsLogged; }
            protected set{ _reqapi.IsLogged = value ; }
        }

        public int TokenCount => _reqapi.TokenCount;

        public RawApi() {
            InitializeMethodGroups();
        }

        internal RawApi( RequestApi api ) :this() { _reqapi = api; }
    }
}
