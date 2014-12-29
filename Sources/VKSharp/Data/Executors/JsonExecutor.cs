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
    public class JsonExecutor : IExecutor {
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
            snakeCaseContractResolver.DefaultMembersSearchFlags |= BindingFlags.NonPublic;

            var ser = new JsonSerializer { ContractResolver = snakeCaseContractResolver };

            ser.Converters.Add( new SnakeCaseEnumConverter { AllowIntegerValues = true, CamelCaseText = false } );
            ser.Converters.Add( new CustomIntConverter());

            ser.Error += ( sender, args ) => {
                var ec = args.ErrorContext;
#if !DEBUG
                //ec.Handled = true;//never fall on release
#endif
            };

            return ser;
        }

#region IO
        public IList<IWebProxy> Proxies => HttpClientHandler.Proxies;
        public IWebProxy CurrentProxy => HttpClientHandler.CurrentProxy;
        private const string ReqExt = "json";
        private static readonly HttpClient Client;
        private static readonly ProxyPoolingHttpClientHandler HttpClientHandler;
        private static async Task<HttpContent> InternalExecRawAsync<T>( VKRequest<T> request, string format ) {
            var ps = request.Parameters.ToList();
            ps.Add( new KeyValuePair<string, string>( "v", "5.21" ) );
            ps.Add( new KeyValuePair<string, string>( "https", "1" ) );
            var path = string.Format( "/method/{0}.{1}", request.MethodName, format );
            if ( request.Token != null ) ps.Add( new KeyValuePair<string, string>( "access_token", request.Token.Token ) );
            return (await Client.PostAsync( new Uri( BuiltInData.Instance.VkDomain + path ), new FormUrlEncodedContent( ps ) )).Content;
        }
#endregion
#region IExecutor
        public async Task<Stream> ExecRawStreamAsync<T>( VKRequest<T> request ) => await( await InternalExecRawAsync( request, ReqExt ) ).ReadAsStreamAsync();
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) => Parse<T>( await ExecRawAsync( request ) );
        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) => await (await InternalExecRawAsync( request, ReqExt )).ReadAsStringAsync();
#endregion
#region Serialization
        private static readonly JsonSerializer Jsonser;
        public VKResponse<T> Parse<T>( string input ) {
            using ( TextReader sr = new StringReader( input ) )
                return ParseStreamReader<T>( sr );
        }

        private static VKResponse<T> ParseStreamReader<T>( TextReader sr ) {
            using ( var jr = new JsonTextReader( sr ) ) {
                var vkResponse = Jsonser.Deserialize<VKResponse<T>>( jr );
                var vkError = vkResponse.Error;
                if ( vkError != null ) throw new VKException( vkError.ErrorMsg, vkError.ErrorCode );
                return vkResponse;
            }
        }

        public VKResponse<T> ParseStream<T>( Stream input ) {
            using ( TextReader sr = new StreamReader( input ) ) return ParseStreamReader<T>( sr );
        }
#endregion
    }
}