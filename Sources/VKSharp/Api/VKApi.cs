using VKSharp.Data.Api;
using VKSharp.Data.Executors;

namespace VKSharp {
    public partial class VKApi {

        protected IExecutor _executor = new SimpleXMLExecutor();
        private readonly RequestApi _reqapi = new RequestApi();
        public IExecutor Executor { get { return _executor; } }
        protected uint ReqCounter { get { return _reqapi.ReqCounter; } }

        protected VKToken CurrentToken { get { return _reqapi.CurrentToken; } }

        public void AddToken( VKToken token ) { _reqapi.AddToken( token ); }

        public bool IsLogged {
            get { return _reqapi.IsLogged; }
            protected set{ _reqapi.IsLogged = value ; }
        }
    }
}
