using VKSharp.Data.Api;
using VKSharp.Data.Executors;

namespace VKSharp {
    public partial class RawApi {
        private readonly RequestApi _reqapi;
        public IExecutor Executor { get; set; }
        protected uint ReqCounter => _reqapi.ReqCounter;

        public VKToken CurrentToken => _reqapi.CurrentToken;

        public void AddToken( VKToken token ) => _reqapi.AddToken( token );

        public bool IsLogged {
            get { return _reqapi.IsLogged; }
            protected set{ _reqapi.IsLogged = value ; }
        }

        public int TokenCount => _reqapi.TokenCount;

        public RawApi() : this( null, null ) { }

        internal RawApi( RequestApi api = null, IExecutor executor = null) {
            InitializeMethodGroups();
            _reqapi = api?? new RequestApi();
            Executor = executor ?? new JsonExecutor();
        }
    }
}
