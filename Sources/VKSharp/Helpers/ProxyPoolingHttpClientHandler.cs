using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace VKSharp.Helpers {
    public class ProxyPoolingHttpClientHandler : HttpMessageHandler, IDisposable {
        private readonly MorozovHandler _handler;

        public ProxyPoolingHttpClientHandler() {
            _handler = new MorozovHandler();
            Proxies = new List<IWebProxy> { null };
        }

        #region HttpClientHandler members

        public bool SupportsAutomaticDecompression => _handler.SupportsAutomaticDecompression;
        public DecompressionMethods AutomaticDecompression {
            get { return _handler.AutomaticDecompression; }
            set { _handler.AutomaticDecompression = value; }
        }

        public bool AllowAutoRedirect {
            get { return _handler.AllowAutoRedirect; }
            set { _handler.AllowAutoRedirect = value; }
        }

        public ClientCertificateOption ClientCertificateOptions {
            get { return _handler.ClientCertificateOptions; }
            set { _handler.ClientCertificateOptions = value; }
        }
        public CookieContainer CookieContainer {
            get { return _handler.CookieContainer; }
            set { _handler.CookieContainer = value; }
        }
        public ICredentials Credentials {
            get { return _handler.Credentials; }
            set { _handler.Credentials = value; }
        }
        public int MaxAutomaticRedirections {
            get { return _handler.MaxAutomaticRedirections; }
            set { _handler.MaxAutomaticRedirections = value; }
        }
        public long MaxRequestContentBufferSize {
            get { return _handler.MaxRequestContentBufferSize; }
            set { _handler.MaxRequestContentBufferSize = value; }
        }
        public bool PreAuthenticate {
            get { return _handler.PreAuthenticate; }
            set { _handler.PreAuthenticate = value; }
        }
        public bool SupportsRedirectConfiguration => _handler.SupportsRedirectConfiguration;
        public bool SupportsProxy => _handler.SupportsProxy;

        public bool UseCookies {
            get { return _handler.UseCookies; }
            set { _handler.UseCookies = value; }
        }
        public bool UseDefaultCredentials {
            get { return _handler.UseDefaultCredentials; }
            set { _handler.UseDefaultCredentials = value; }
        }
        public bool UseProxy {
            get { return _handler.UseProxy; }
            set { _handler.UseProxy = value; }
        }
        public bool AllowPipelining {
            get { return _handler.AllowPipelining; }
            set { _handler.AllowPipelining = value; }
        }
        public AuthenticationLevel AuthenticationLevel {
            get { return _handler.AuthenticationLevel; }
            set { _handler.AuthenticationLevel = value; }
        }
        public RequestCachePolicy CachePolicy {
            get { return _handler.CachePolicy; }
            set { _handler.CachePolicy = value; }
        }
        public TimeSpan ContinueTimeout {
            get { return _handler.ContinueTimeout; }
            set { _handler.ContinueTimeout = value; }
        }
        public TokenImpersonationLevel ImpersonationLevel {
            get { return _handler.ImpersonationLevel; }
            set { _handler.ImpersonationLevel = value; }
        }
        public int MaxResponseHeadersLength {
            get { return _handler.MaxResponseHeadersLength; }
            set { _handler.MaxResponseHeadersLength = value; }
        }
        public int ReadWriteTimeout {
            get { return _handler.ReadWriteTimeout; }
            set { _handler.ReadWriteTimeout = value; }
        }
        public RemoteCertificateValidationCallback ServerCertificateValidationCallback {
            get { return _handler.ServerCertificateValidationCallback; }
            set { _handler.ServerCertificateValidationCallback = value; }
        }
        public bool UnsafeAuthenticatedConnectionSharing {
            get { return _handler.UnsafeAuthenticatedConnectionSharing; }
            set { _handler.UnsafeAuthenticatedConnectionSharing = value; }
        }
        public X509CertificateCollection ClientCertificates => _handler.ClientCertificates;



        public new void Dispose()
        {
            base.Dispose();
            _handler.Dispose();
        }

        #endregion

        public IWebProxy CurrentProxy => _handler.Proxy;

        public IList<IWebProxy> Proxies { get; }
        private int _currentProxyIndex;

        protected override Task<HttpResponseMessage> SendAsync( HttpRequestMessage request, CancellationToken cancellationToken ) {
            NextProxy();
            return _handler.SendAsyncPublic( request, cancellationToken );
        }

        private void NextProxy() {
            if ( Proxies == null || Proxies.Count == 0 ) {
                _handler.Proxy = null;
                return;
            }
            _currentProxyIndex++;
            _handler.Proxy = Proxies[ _currentProxyIndex % Proxies.Count ];
        }
    }
}
