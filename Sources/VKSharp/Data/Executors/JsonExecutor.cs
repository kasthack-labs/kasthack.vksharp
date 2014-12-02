using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp.Data.Executors {
    public class JsonExecutor : IExecutor {
        #region IO
        private const string ReqExt = "json";
        private static readonly HttpClient Client = new HttpClient();

        private static async Task<string> ExecRawAsync<T>( VKRequest<T> request, string format ) where T : IVKEntity<T> {
            var ps = request.Parameters.ToList();
            ps.Add( new KeyValuePair<string, string>( "v", "5.21" ) );
            ps.Add( new KeyValuePair<string, string>( "https", "1" ) );
            var path = "/method/" + request.MethodName + "." + format;
            if ( request.Token != null ) ps.Add( new KeyValuePair<string, string>( "access_token", request.Token.Token ) );
            return
                await
                ( await Client.PostAsync( new Uri( BuiltInData.Instance.VkDomain + path ), new FormUrlEncodedContent( ps ) ) ).Content
                                                                                                                              .ReadAsStringAsync
                    ();
        }
        #endregion


        public Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> { throw new NotImplementedException(); }
        public Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> => ExecRawAsync( request, ReqExt );

        #region Serializtion
        public class VResponse<T> {
            public T Response { get; set; }
        }

        internal class SnakeCaseContractResolver : DefaultContractResolver {
            protected override string ResolvePropertyName( string propertyName ) {
                //return base.ResolvePropertyName( propertyName );
                return propertyName.ToSnake(); //ToMeth( propertyName, true );
            }
            private static string ToMeth( string name, bool p = false ) {
                if ( string.IsNullOrEmpty( name ) ) return name;
                var t = new StringBuilder();
                t.Append( p ? Char.ToLower( name[ 0 ] ) : Char.ToUpper( name[ 0 ] ) );
                for ( var index = 1; index < name.Length; index++ ) {
                    var c = name[ index ];
                    //add '_' before numbers and capitals 
                    if ( c == '.' || c == '_' ) t.Append( Char.ToUpper( name[ ++index ] ) );
                    else t.Append( c );
                }
                return t.ToString();
            }
        }
        public VKResponse<T> Parse<T>( string input ) where T : IVKEntity<T> {
            var jsonser = new JsonSerializer { ContractResolver = new SnakeCaseContractResolver() };
            using ( var sr = new StringReader( input ) )
                using ( var jr = new JsonTextReader( sr ) ) {
                    var ret2 = jsonser.Deserialize<VResponse<T>>( jr );
                    Console.WriteLine( ret2.Response );
                }
            var ret1 = JsonConvert.DeserializeObject<VResponse<T>>( input );
            return null;
        }

        #endregion
    }
}