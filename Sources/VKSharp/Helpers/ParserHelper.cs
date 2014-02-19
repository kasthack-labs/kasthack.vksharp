using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EpicMorg.Net;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;

namespace VKSharp.Helpers {
    public static class ParserHelper {
        private static Lazy<Dictionary<Type, object>> _parsers =
            new Lazy<Dictionary<Type, object>>(
                () => new Dictionary<Type, object> {
                    {typeof(string), new Func<string,string>(s=>s) },
                    {typeof(int?),  new Func<string,int?>(s => (int?)int.Parse( s ))},
                    {typeof(uint),  new Func<string,uint>(uint.Parse)},
                    {typeof(uint?), new Func<string,uint?>(s => (uint?)uint.Parse( s )) },
                    {typeof(long?), new Func<string,long?>(s => (long?)long.Parse( s )) },
                    {typeof(byte?), new Func<string,byte?>(s => (byte?)byte.Parse( s )) },
                    {typeof(bool?), new Func<string,bool?>(a=>(bool?)(int.Parse( a ) == 1)) },
                } );
        private static Lazy<Type> _actionTypeLazy = new Lazy<Type>( () => typeof( Action<object, object> ).GetGenericTypeDefinition() );
        private static Type ActionType {
            get {
                return _actionTypeLazy.Value;
            }
        }
        private static Dictionary<Type, object> Parsers {
            get {
                return _parsers.Value;
            }
        }
        private static Action<TEntity, string> GetParser<TEntity, TProperty>( PropertyInfo property ) {
            return ( a, b ) => (
                        (Action<TEntity, TProperty>)
                        Delegate.CreateDelegate(
                            typeof( Action<TEntity, TProperty> ),
                            null,
                            property.GetSetMethod()
                        )
                    )(
                        a,
                        (
                            (Func<string, TProperty>)
                            Parsers[ typeof( TProperty ) ]
                        )( b )
                    );
        }
        private static void GetParsers<TEntity, TProperty>( Dictionary<string, Action<TEntity, string>> ret, Dictionary<Type, PropertyInfo[]> props ) {
            if ( !props.ContainsKey( typeof (TProperty) ) ) return;
            foreach ( var pi in props[ typeof( TProperty ) ] )
                ret.Add( ConvertName( pi.Name ), GetParser<TEntity, TProperty>( pi ) );
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
            var ret = new Dictionary<string, Action<T, string>>();
            var enityType = typeof( T );
            var props = enityType
                .GetProperties()
                .GroupBy( a=>a.PropertyType )
                .Where( a=>Parsers.ContainsKey( a.Key ) )
                .ToDictionary( a=>a.Key, a=>a.ToArray() );
            //bug. Don't know how to implement it right
            GetParsers<T, string>( ret, props );
            GetParsers<T, int?>( ret, props );
            GetParsers<T, uint?>( ret, props );
            GetParsers<T, uint>( ret, props );
            GetParsers<T, long?>( ret, props );
            GetParsers<T, byte?>( ret, props );
            GetParsers<T, bool?>( ret, props );
            return ret;
        }
        public static string ConvertName( string name ) {
            var t = new StringBuilder();
            t.Append( Char.ToLower( name[ 0 ] ) );
            for (var index = 1; index < name.Length; index++) {
                var c = name[ index ];
                if ( !Char.IsUpper( c ) ) t.Append( c );
                else {
                    t.Append( '_' );
                    t.Append( Char.ToLower( c ) );
                }
            }
            return t.ToString();
        }
    }
}
