using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpicMorg.Net;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;

namespace VKSharp.Helpers {
    public static class ParserHelper {
        private static Lazy<Dictionary<Type, Func<string, object>>> _parsers = new Lazy<Dictionary<Type, Func<string, object>>>( () => new Dictionary<Type, Func<string, object>> {
            {typeof(string), s=>s },
            {typeof(int?),  s => (int?)int.Parse( s )},
            {typeof(uint),  s => uint.Parse( s )},
            {typeof(uint?), s => (uint?)uint.Parse( s ) },
            {typeof(long?), s => (long?)long.Parse( s ) },
            {typeof(byte?), s => (byte?)byte.Parse( s ) },
            {typeof(bool?), a=>(bool?)(int.Parse( a ) == 1) },
        });

        private static Dictionary<Type, Func<string, object>> Parsers {
            get {
                return _parsers.Value;
            }
        }

        public static async Task<string> ExecRawAsync<T>( VKRequest<T> request, string extension ) where T : IVKEntity<T> {
            var bID = BuiltInData.Instance;
            var vk = bID.VKDomain;
            var query = String.Join( "&", request.Parameters.Where( a => a.Value != "" ).Select( a => a.Key + "=" + a.Value ) );
            var queryB = new StringBuilder();
            queryB.Append( "/method/" );
            queryB.Append( request.MethodName );
            queryB.Append( @"." );
            queryB.Append( extension );
            if ( request.Token != null ) {
                queryB.Append( "?access_token=" );
                queryB.Append( request.Token.Token );
                if ( new Uri( vk ).Scheme != "https" ) {
                    queryB.Append(
                        "&sig=" +
                        BitConverter.ToString(
                            bID.Hasher.ComputeHash(
                                bID.TextEncoding.
                                GetBytes(
                                    queryB + "&" + query +
                                    request.Token.Sign
                                )
                            )
                        ).
                        Replace( "-", "" ).
                        ToLower()
                    );
                }
            }
            queryB.Insert( 0, vk );
            return await AWC.DownloadStringAsync(
                queryB.ToString(),
                bID.TextEncoding,
                null,
                null,
                AWC.RequestMethod.Post,
                query,
                40000
            );
        }

        public static Dictionary<string, Action<T, string>> GetStringParsers<T>() {
            var enityType = typeof( T );
            var props = enityType.GetProperties();
            var ret = new Dictionary<string, Action<T, string>>();

            for (var index = 0; index < props.Length; index++) {
                var v = props[ index ];
                var pt = v.PropertyType;
                if ( !Parsers.ContainsKey( pt ) ) continue;
                var key = v.Name;
                var setter =(Action<T, object>)
                    Delegate.CreateDelegate(
                        typeof (Action).GetGenericTypeDefinition().MakeGenericType( typeof (T), pt ),
                        null,
                        v.GetSetMethod() );
                Action<T, string> parser = ( arg1, s ) => setter( arg1, Parsers[ pt ]( s ) );
                ret.Add( key, parser );
            }
            return ret;
        }
    }
}
