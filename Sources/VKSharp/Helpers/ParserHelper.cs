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
        private static class _p {
            internal static string _s( string a ) { return a; }
        }
        private static Lazy<Dictionary<Type, object>> _parsers = new Lazy<Dictionary<Type, object>>(()=>new Dictionary<Type, object>() {
            {typeof(string), new Func<string,string>(_p._s) },
            {typeof(int), new Func<string,int>(int.Parse) },
            {typeof(uint), new Func<string,uint>(uint.Parse) },
            {typeof(long), new Func<string,long>(long.Parse) },
            {typeof(byte), new Func<string,byte>(byte.Parse) },
            {typeof(bool), new Func<string,bool>((a)=>int.Parse( a ) == 1) },
        });

        private static Dictionary<Type, object> Parsers {
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

            foreach (var v in props.Where( a => Parsers.ContainsKey( a.PropertyType ) )) {
                var key = v.Name;
                var setForAnyFoo = (Action<T,string>) Delegate.CreateDelegate(typeof(Action<T, string>), null,v.GetSetMethod());
            }
        }
    }
}
