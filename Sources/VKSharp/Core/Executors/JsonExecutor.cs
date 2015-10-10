using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Exceptions;

namespace VKSharp.Data.Executors {
    public class JsonExecutor : IExecutor
    {
        private const string ReqExt = "json";
        private static readonly HttpClient Client;
        private static readonly ProxyPoolingHttpClientHandler HttpClientHandler;
        public IList<IWebProxy> Proxies => HttpClientHandler.Proxies;
        public IWebProxy CurrentProxy => HttpClientHandler.CurrentProxy;

        static JsonExecutor() {
            //required for parallel IO
            //default conn limit is 2
            ServicePointManager.DefaultConnectionLimit = Math.Max( 25, ServicePointManager.DefaultConnectionLimit );

            //client w compresssion & proxy pooling
            HttpClientHandler = new ProxyPoolingHttpClientHandler();
            if ( HttpClientHandler.SupportsAutomaticDecompression )
                HttpClientHandler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            Client = new HttpClient( HttpClientHandler );

            Jsonser = GetSerializer();
        }

        public static JsonSerializer GetSerializer() {
            //snake case parsing
            var snakeCaseContractResolver = new SnakeCaseContractResolver();
#pragma warning disable 618
            snakeCaseContractResolver.DefaultMembersSearchFlags |= BindingFlags.NonPublic;
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
        private static async Task<HttpContent> InternalExecRawAsync<T>( VKRequest<T> request, string format ) {
            var ps = request.Parameters;
            ps.Add(  "v", "5.29"  );//todo: privacy
            ps.Add(  "https", "1"  );
            var path = $"/method/{request.MethodName}.{format}";
            if ( request.Token != null ) ps.Add( "access_token", request.Token.Token  );
            foreach ( var source in ps.ToArray().Where( source => string.IsNullOrEmpty( source.Value ) ) ) ps.Remove( source.Key );
            return (await Client.PostAsync( new Uri( BuiltInData.Instance.VkDomain + path ), new FormUrlEncodedContent( ps ) ).ConfigureAwait( false )).Content;
        }
#endregion
#region IExecutor
        public virtual async Task<Stream> ExecRawStreamAsync<T>( VKRequest<T> request ) => await( await InternalExecRawAsync( request, ReqExt ).ConfigureAwait(false)).ReadAsStreamAsync().ConfigureAwait(false);
        public virtual async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) => Parse<T>( await ExecRawAsync( request ).ConfigureAwait(false));
        public virtual async Task<string> ExecRawAsync<T>( VKRequest<T> request ) => await (await InternalExecRawAsync( request, ReqExt ).ConfigureAwait(false)).ReadAsStringAsync().ConfigureAwait(false);
#endregion
#region Serialization
        private static readonly JsonSerializer Jsonser;
        public virtual VKResponse<T> Parse<T>( string input ) {
            using ( TextReader sr = new StringReader( input ) )
                return ParseStreamReader<T>( sr );
        }

        protected static VKResponse<T> ParseStreamReader<T>( TextReader sr ) {
            using ( var jr = new JsonTextReader( sr ) ) {
                var vkResponse = Jsonser.Deserialize<VKResponse<T>>( jr );
                var vkError = vkResponse.Error;
                if ( vkError != null ) throw new VKException( vkError.ErrorMsg, vkError.ErrorCode );
                return vkResponse;
            }
        }

        public virtual VKResponse<T> ParseStream<T>( Stream input ) {
            using ( TextReader sr = new StreamReader( input ) ) return ParseStreamReader<T>( sr );
        }
#endregion
    }
}