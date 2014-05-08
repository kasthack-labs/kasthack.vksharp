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
                    {typeof(string), new Func<string,string>(s=>s.Trim('\r','\n','\t', ' ')) },
                    {typeof(int?),  new Func<string,int?>(s => {int r; return int.TryParse( s, out r)?(int?)r:null;})},
                    {typeof(uint?), new Func<string,uint?>(s => {uint r; return uint.TryParse( s, out r)?(uint?)r:null;})},
                    {typeof(long?), new Func<string,long?>(s => {long r; return long.TryParse( s, out r)?(long?)r:null;})},
                    {typeof(ulong?), new Func<string,ulong?>(s => {ulong r; return ulong.TryParse( s, out r)?(ulong?)r:null;})},
                    {typeof(byte?), new Func<string,byte?>(s => {byte r; return byte.TryParse( s, out r)?(byte?)r:null;})},
                    {typeof(ushort?), new Func<string,ushort?>(s => {ushort r; return ushort.TryParse( s, out r)?(ushort?)r:null;})},
                    {typeof(bool?), new Func<string,bool?>(s=>{int r; return int.TryParse( s, out r)?(bool?)(r==1):null;})},
                    //==========================
                    {typeof(int),  new Func<string,int>(s => {int r; return int.TryParse( s, out r)?r:0;})},
                    {typeof(uint), new Func<string,uint>(s => {uint r; return uint.TryParse( s, out r)?r:0U;})},
                    {typeof(long), new Func<string,long>(s => {long r; return long.TryParse( s, out r)?r:0L;})},
                    {typeof(ulong), new Func<string,ulong>(s => {ulong r; return ulong.TryParse( s, out r)?r:0UL;})},
                    {typeof(byte), new Func<string,byte>(s => {byte r; return byte.TryParse( s, out r)?r:(byte)0;})},
                    {typeof(ushort), new Func<string,ushort>(s => {ushort r; return ushort.TryParse( s, out r)?r:(ushort)0;})},
                    {typeof(bool), new Func<string,bool>(s=>{int r; return int.TryParse( s, out r) && (r==1);})},
                } );
        private static Dictionary<Type, object> Parsers {
            get {
                return _parsers.Value;
            }
        }
        private static Action<TEntity, string> GetParser<TEntity, TProperty>( PropertyInfo property ) {
            //don't inline these funcs
            var p = ( (Func<string, TProperty>) Parsers[ typeof( TProperty ) ] );
            var s = (Action<TEntity, TProperty>) Delegate.CreateDelegate(
                typeof( Action<TEntity, TProperty> ),
                null,
                property.GetSetMethod()
            );
            return ( a, b ) => s( a, p( b ) );
        }
        private static void GetParsers<TEntity, TProperty>(
            IDictionary<string, Action<TEntity, string>> ret,
            IReadOnlyDictionary<Type, PropertyInfo[]> props
            ) {
            if ( !props.ContainsKey( typeof( TProperty ) ) ) return;
            foreach ( var pi in props[ typeof( TProperty ) ] )
                ret.Add( ConvertName( pi.Name ), GetParser<TEntity, TProperty>( pi ) );
        }

        public static async Task<string> ExecRawAsync<T>( VKRequest<T> request, string extension )
            where T : IVKEntity<T> {
            var bId = BuiltInData.Instance;
            var vk = bId.VKDomain;
            var query = String.Join(
                "&",
                request
                    .Parameters
                    .Where( a => a.Value != "" )
                    .Select( a => a.Key + "=" + a.Value )
            );
            var queryB = new StringBuilder();
            queryB.Append( "/method/" );
            queryB.Append( request.MethodName );
            queryB.Append( @"." );
            queryB.Append( extension );
            if ( request.Token != null ) {
                queryB.Append( "?access_token=" );
                queryB.Append( request.Token.Token );
                queryB.Append( "&v=5.21" );
                if ( new Uri( vk ).Scheme != "https" )
                    queryB.Append(
                        "&sig="
                        + BitConverter.ToString(
                            bId.Hasher.ComputeHash(
                                bId.TextEncoding
                                .GetBytes( queryB + "&" + query + request.Token.Sign ) )
                        )
                        .Replace( "-", "" )
                        .ToLower() );
            }
            queryB.Insert( 0, vk );
            var e = string.IsNullOrEmpty( query );
            return await AWC.DownloadStringAsync(
                queryB.ToString(),
                bId.TextEncoding,
                null,
                null,
                e ? AWC.RequestMethod.Get: AWC.RequestMethod.Post,
                e?null:query,
                40000
            );
        }
        public static Dictionary<string, Action<T, string>> GetStringParsers<T>() {
            var ret = new Dictionary<string, Action<T, string>>();
            var enityType = typeof( T );
            var props = enityType
                .GetProperties()
                .GroupBy( a => a.PropertyType )
                .Where( a => Parsers.ContainsKey( a.Key ) )
                .ToDictionary( a => a.Key, a => a.ToArray() );
            //bug. Don't know how to implement it right
            GetParsers<T, string>( ret, props );
            GetParsers<T, int>( ret, props );
            GetParsers<T, int?>( ret, props );
            GetParsers<T, uint>( ret, props );
            GetParsers<T, uint?>( ret, props );
            GetParsers<T, long>( ret, props );
            GetParsers<T, long?>(ret, props);
            GetParsers<T, ulong>(ret, props);
            GetParsers<T, ulong?>(ret, props);
            GetParsers<T, byte>( ret, props );
            GetParsers<T, byte?>( ret, props );
            GetParsers<T, bool>( ret, props );
            GetParsers<T, bool?>( ret, props );
            GetParsers<T, ushort>( ret, props );
            GetParsers<T, ushort?>( ret, props );
            return ret;
        }
        public static string ConvertName( string name ) {
            var t = new StringBuilder();
            t.Append( Char.ToLower( name[ 0 ] ) );
            for ( var index = 1; index < name.Length; index++ ) {
                var c = name[ index ];
                //add '_' b4 numbers and captials 
                if (
                    Char.IsUpper( c )
                    ||
                    (
                        Char.IsNumber( c )
                        &&
                        !Char.IsNumber( name[ index - 1 ] )
                    )
                ) {
                    t.Append( '_' );
                    t.Append( Char.ToLower( c ) );
                    continue;
                }
                t.Append( c );
            }
            return t.ToString();
        }
    }
}
