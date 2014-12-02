using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Exceptions;

namespace VKSharp.Data.Executors {
    public class JsonExecutor : IExecutor {
        #region IO
        private const string ReqExt = "json";
        private static readonly HttpClient Client = new HttpClient();
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
        #endregion
        #region IExecutor
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) => Parse<T>( await ExecRawAsync( request ) );
        public Task<string> ExecRawAsync<T>( VKRequest<T> request ) => ExecRawAsync( request, ReqExt );
        #endregion
        #region Serialization
        private static readonly JsonSerializer Jsonser;

        static JsonExecutor() {
            var snakeCaseContractResolver = new SnakeCaseContractResolver();
            snakeCaseContractResolver.DefaultMembersSearchFlags |= BindingFlags.NonPublic;
            Jsonser = new JsonSerializer { ContractResolver = snakeCaseContractResolver };
        }

        internal class SnakeCaseContractResolver : DefaultContractResolver {
            protected override string ResolvePropertyName( string propertyName ) => propertyName.ToSnake();
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