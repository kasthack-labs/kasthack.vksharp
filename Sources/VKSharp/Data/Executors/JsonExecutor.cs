using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
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
            
            //snake case parsing
            var snakeCaseContractResolver = new SnakeCaseContractResolver();
            snakeCaseContractResolver.DefaultMembersSearchFlags |= BindingFlags.NonPublic;
            Jsonser = new JsonSerializer { ContractResolver = snakeCaseContractResolver };
            Jsonser.Converters.Add( new SnakeCaseEnumConverter() {
                AllowIntegerValues = true,
                CamelCaseText = false
            } );
        }
        #region IO
        public IList<IWebProxy> Proxies => HttpClientHandler.Proxies;
        public IWebProxy CurrentProxy => HttpClientHandler.CurrentProxy;
        private const string ReqExt = "json";
        private static readonly HttpClient Client;
        private static readonly ProxyPoolingHttpClientHandler HttpClientHandler;
        private static async Task<string> ExecRawAsync<T>( VKRequest<T> request, string format ) {
            var ps = request.Parameters.ToList();
            ps.Add( new KeyValuePair<string, string>( "v", "5.21" ) );
            ps.Add( new KeyValuePair<string, string>( "https", "1" ) );
            var path = "/method/" + request.MethodName + "." + format;
            if ( request.Token != null ) ps.Add( new KeyValuePair<string, string>( "access_token", request.Token.Token ) );
            return await (
                    await Client.PostAsync( new Uri( BuiltInData.Instance.VkDomain + path ), new FormUrlEncodedContent( ps ) )
                ).Content.ReadAsStringAsync();
        }
#if DEBUG
        public async Task<string> TestProxy(string address) { return await Client.GetStringAsync( address ); }
#endif
#endregion
        #region IExecutor
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) => Parse<T>( await ExecRawAsync( request ) );
        public Task<string> ExecRawAsync<T>( VKRequest<T> request ) => ExecRawAsync( request, ReqExt );
        #endregion
        #region Serialization
        private static readonly JsonSerializer Jsonser;

        private class SnakeCaseContractResolver : DefaultContractResolver {
            protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
        }
        //todo:implement
        private class SnakeCaseEnumConverter : StringEnumConverter {
            public override bool CanConvert( Type objectType ) {
                var btype = objectType;
                if ( objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof( Nullable<> ) )
                    btype = Nullable.GetUnderlyingType( objectType );
                return btype.IsEnum;
            }
            public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer ) {
                var isNullable = ReflectionUtils.IsNullableType( objectType );
                var t = isNullable ? Nullable.GetUnderlyingType( objectType ) : objectType;
                if ( reader.TokenType == JsonToken.Null ) {
                    if ( !ReflectionUtils.IsNullableType( objectType ) )
                        throw JsonSerializationException.Create( reader, "Cannot convert null value to {0}.".FormatWith( CultureInfo.InvariantCulture, objectType ) );
                    return null;
                }
                try {
                    switch ( reader.TokenType ) {
                        case JsonToken.String:
                            var enumText = reader.Value.ToString()
                                .ToMeth();//the only changed line
                            return EnumUtils.ParseEnumName( enumText, isNullable, t );
                        case JsonToken.Integer:
                            if ( !AllowIntegerValues )
                                throw JsonSerializationException.Create( reader, "Integer value {0} is not allowed.".FormatWith( CultureInfo.InvariantCulture, reader.Value ) );
                            return ConvertUtils.ConvertOrCast( reader.Value, CultureInfo.InvariantCulture, t );
                    }
                }
                catch ( Exception ex ) {
                    throw JsonSerializationException.Create( reader, "Error converting value {0} to type '{1}'.".FormatWith( CultureInfo.InvariantCulture, MiscellaneousUtils.FormatValueForPrint( reader.Value ), objectType ), ex );
                }
                // we don't actually expect to get here.
                throw JsonSerializationException.Create( reader, "Unexpected token {0} when parsing enum.".FormatWith( CultureInfo.InvariantCulture, reader.TokenType ) );
            }
        }

        public VKResponse<T> Parse<T>( string input ) {
            using ( var sr = new StringReader( input ) )
            using ( var jr = new JsonTextReader( sr ) ) {
                var vkResponse = Jsonser.Deserialize<VKResponse<T>>( jr );
                var vkError = vkResponse.Error;
                if ( vkError != null ) throw new VKException( vkError.ErrorMsg, vkError.ErrorCode );
                return vkResponse;
            }
        }
        #endregion
    }
}