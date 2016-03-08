using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace kasthack.vksharp.Internal {
    /*
        Pure Public Morozov antipattern
    */
#if !PORTABLE
    internal class MorozovHandler : WebRequestHandler {
        private static readonly FieldInfo _proxyInfo;
        static MorozovHandler() {
            _proxyInfo = typeof(HttpClientHandler).
                GetField( "proxy", BindingFlags.NonPublic | BindingFlags.Instance );

        }

        public new IWebProxy Proxy {
            get {
                return base.Proxy;
            }
            set {
                _proxyInfo.SetValue( this, value );
            }
        }

        public Task<HttpResponseMessage> SendAsyncPublic( HttpRequestMessage request, CancellationToken cancellationToken ) {
            return base.SendAsync( request, cancellationToken );
        }
    }
#endif
}