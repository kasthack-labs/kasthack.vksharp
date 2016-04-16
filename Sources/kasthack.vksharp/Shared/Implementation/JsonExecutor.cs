using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using kasthack.vksharp.Internal;
using kasthack.vksharp.Internal.Converters;
using Newtonsoft.Json;

namespace kasthack.vksharp.Implementation {
    public class JsonExecutor : IExecutor
    {
        private const string ReqExt = "json";
        private static readonly HttpClient Client;
        private static int _maxRps =0;
        //private static int _maxConnections =25;
        private static readonly object rpsLimiterLock = new object();
        private static SemaphoreSlim rpsLimiter;
        private static readonly
#if !PORTABLE
            ProxyPoolingHttpClientHandler
#else
            HttpClientHandler
#endif
            HttpClientHandler;
#if !PORTABLE
        public IList<IWebProxy> Proxies => HttpClientHandler.Proxies;
        public IWebProxy CurrentProxy => HttpClientHandler.CurrentProxy;

        public static int MaxRps {
            get
            {
                return _maxRps;
            }
            set
            {
                lock (rpsLimiterLock) {
                    if (rpsLimiter!=null) for ( int i = 0; i < _maxRps; i++ ) rpsLimiter.Release();
                    rpsLimiter?.Dispose();
                    rpsLimiter = new SemaphoreSlim(_maxRps = value);
                }
            }
        }
        

        //public static int MaxConnections { get { return _maxConnections; } set { _maxConnections = value; } }

#endif

        static JsonExecutor() {
            //required for parallel IO
            //default conn limit is 2
#if !PORTABLE
            ServicePointManager.DefaultConnectionLimit = Math.Max( 25, ServicePointManager.DefaultConnectionLimit );
#endif
            //client w compresssion & proxy pooling
            HttpClientHandler = new
#if !PORTABLE
             ProxyPoolingHttpClientHandler();
#else
            HttpClientHandler();
#endif
            if ( HttpClientHandler.SupportsAutomaticDecompression )
                HttpClientHandler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            Client = new HttpClient( HttpClientHandler );

            Jsonser = GetSerializer();
        }

        public static JsonSerializer GetSerializer() {
            //snake case parsing
            var snakeCaseContractResolver = new SnakeCaseContractResolver();
#pragma warning disable 618
#if !PORTABLE
            snakeCaseContractResolver.DefaultMembersSearchFlags |= BindingFlags.NonPublic;
#endif
#pragma warning restore 618

            var ser = new JsonSerializer { ContractResolver = snakeCaseContractResolver };

            ser.Converters.Add( new SnakeCaseEnumConverter { AllowIntegerValues = true, CamelCaseText = false } );
            ser.Converters.Add(new UnixTimeConverter());

            ser.Converters.Add(new NumberConverter<int>(a=>int.Parse( a )));
            ser.Converters.Add(new NumberConverter<long>(a => long.Parse(a)));
            ser.Converters.Add(new NumberConverter<uint>(a => uint.Parse(a)));
            ser.Converters.Add(new NumberConverter<ulong>(a => ulong.Parse(a)));
            ser.Converters.Add(new NumberConverter<short>(a => short.Parse(a)));
            ser.Converters.Add(new NumberConverter<ushort>(a => ushort.Parse(a)));
            ser.Converters.Add(new NumberConverter<byte>(a => byte.Parse(a)));
            ser.Converters.Add(new NumberConverter<sbyte>(a => sbyte.Parse(a)));


            ser.Error += ( sender, args ) => {
                var ec = args.ErrorContext;
#if !DEBUG
                ec.Handled = true;//never fall on release
#endif
            };

            return ser;
        }

#region IO
        private async Task<HttpContent> InternalExecRawAsync<T>( Request<T> request, string format ) {
            var ps = request.Parameters;
            ps.Add(  "v", "5.29"  );//todo: privacy
            ps.Add(  "https", "1"  );
            var path = $"/method/{request.MethodName}.{format}";
            if ( request.Token != null ) ps.Add( "access_token", request.Token.Value  );
            foreach ( var source in ps.ToArray().Where( source => string.IsNullOrEmpty( source.Value ) ) ) ps.Remove( source.Key );
            if ( _maxRps > 0 ) {
                
            }
            if (MaxRps > 0) await rpsLimiter.WaitAsync().ConfigureAwait( false );

            ConfiguredTaskAwaitable<HttpResponseMessage> postRequest;
            try {
                postRequest = Client.PostAsync( new Uri( BuiltInData.Instance.VkDomain + path ), new FormUrlEncodedContent( ps ) ).ConfigureAwait( false );
            }
            finally {
                if (MaxRps > 0) {
                    //it's not awaited for purpose
                    //
                    Task.Delay( 1100 ).ContinueWith( (Action<Task>) ( task => rpsLimiter.Release() ) ).ConfigureAwait( false );
                }
            }
            return (await postRequest).Content;
        }
#endregion
#region IExecutor
        public virtual async Task<Stream> ExecRawStreamAsync<T>(Request<T> request ) => await( await InternalExecRawAsync( request, ReqExt ).ConfigureAwait(false)).ReadAsStreamAsync().ConfigureAwait(false);
        public virtual async Task<VkResponse<T>> ExecAsync<T>(Request<T> request ) => Parse<T>( await ExecRawAsync( request ).ConfigureAwait(false));
        public virtual async Task<string> ExecRawAsync<T>(Request<T> request ) => await (await InternalExecRawAsync( request, ReqExt ).ConfigureAwait(false)).ReadAsStringAsync().ConfigureAwait(false);
#endregion
#region Serialization
        private static readonly JsonSerializer Jsonser;

        public virtual VkResponse<T> Parse<T>( string input ) {
            using ( TextReader sr = new StringReader( input ) )
                return ParseStreamReader<T>( sr );
        }

        protected static VkResponse<T> ParseStreamReader<T>( TextReader sr ) {
            using ( var jr = new JsonTextReader( sr ) ) {
                var vkResponse = Jsonser.Deserialize<VkResponse<T>>( jr );
                var vkError = vkResponse.Error;
                if ( vkError != null ) throw new VkException( vkError.ErrorMsg, vkError.ErrorCode );
                return vkResponse;
            }
        }

        public virtual VkResponse<T> ParseStream<T>( Stream input ) {
            using ( TextReader sr = new StreamReader( input ) ) return ParseStreamReader<T>( sr );
        }
#endregion
    }
}