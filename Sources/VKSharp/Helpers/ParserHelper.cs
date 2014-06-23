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

        private static readonly Dictionary<Type, object> Parsers = new Dictionary<Type, object> {
                    {typeof(string), new Func<string,string>(s=>s.Trim('\r','\n','\t', ' ')) },
                    {typeof(bool), new Func<string,bool>(s=>{int r; return int.TryParse( s, out r) && (r==1);})},
                    {typeof(bool?), new Func<string,bool?>(s=>{int r; return int.TryParse( s, out r)?(bool?)(r==1):null;})},
                };
        private delegate bool GenericTryParse<T>(string input, out T value);
        private static readonly Lazy<MethodInfo> GetNullableTryParseBuilderLazy = new Lazy<MethodInfo>(
            () => typeof(ParserHelper).GetMethod("BuildNullableTryParse", BindingFlags.Static | BindingFlags.NonPublic));
        private static MethodInfo GetNullableTryParseBuilder { get { return GetNullableTryParseBuilderLazy.Value; } }

        //Don't rename. Invoked via reflection only.
        private static Func<string, T> BuildTryParse<T>() {
            var m = GetTryParse<T>();
            if ( m == null ) return null;
            var del = (GenericTryParse<T>)m.CreateDelegate( typeof( GenericTryParse<T> ) );
            return s => { T r; return del( s, out r ) ? r : default( T ); };
        }

        private static MethodInfo GetTryParse<T>() {
            var t = typeof( T );
            return t.GetMethod("TryParse", BindingFlags.Static | BindingFlags.Public);
        }

        //Don't rename. Invoked via reflection only.
        private static Func<string, T?> BuildNullableTryParse<T>() where T: struct {
            var m = GetTryParse<T>();
            if (m == null) return null;
            var del = (GenericTryParse<T>)m.CreateDelegate(typeof(GenericTryParse<T>));
            return s => { T r; return del(s, out r) ? (T?)r : null; };
        }
        private static Action<TEntity, string> GetParser<TEntity, TProperty>( PropertyInfo property ) {
            Func<string, TProperty> p;
            object o;
            var tp = typeof( TProperty );
            //Build parser if we don't have it yet
            if ( !Parsers.TryGetValue( tp, out o ) ) {
                //Tentity is T? -> build nullable parser
                if ( tp.IsGenericType && tp.GetGenericTypeDefinition() == typeof( Nullable<> ) ) {
                    var to = tp.GetGenericArguments();
                    var rettype = typeof( Func<,> ).MakeGenericType( typeof( string ), tp );
                    p = ( (Func<Func<string, TProperty>>)GetNullableTryParseBuilder.MakeGenericMethod( to )
                        .CreateDelegate( typeof( Func<> ).MakeGenericType( rettype ) ) )();
                }
                else  p = BuildTryParse<TProperty>();
                if ( p == null )
                    return null;
                Parsers.Add( tp, p );
            }
            else p = (Func<string, TProperty>)o;
            var updater = (Action<TEntity, TProperty>) Delegate.CreateDelegate( typeof( Action<TEntity, TProperty> ),
                null, property.GetSetMethod() );
            return ( entity, value ) => updater( entity, p( value ) );
        }

        private static void GetParsers<TEntity, TProperty>( IDictionary<string, Action<TEntity, string>> ret,
            IReadOnlyDictionary<Type, PropertyInfo[]> props ) {
            var tp = typeof( TProperty );
            if (!props.ContainsKey(tp)) return;
            foreach ( var pi in props[ tp ] ) {
                var p = GetParser<TEntity, TProperty>( pi );
                if (p!=null)
                    ret.Add( ConvertName( pi.Name ), p );
            }
        }

        public static async Task<string> ExecRawAsync<T>( VKRequest<T> request, string extension )
            where T : IVKEntity<T> {
            var bId = BuiltInData.Instance;
            var vk = bId.VKDomain;
            var query = String.Join( "&", request
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
            var entityType = typeof( T );
            var props = entityType
                .GetProperties()
                .GroupBy( a => a.PropertyType )
                .Where( a => Parsers.ContainsKey( a.Key ) )
                .ToDictionary( a => a.Key, a => a.ToArray() );
            var method = typeof( Helper ).GetMethod( "GetParsers", BindingFlags.Static | BindingFlags.NonPublic );
            foreach ( var type in props.Keys.ToArray() )
                method.MakeGenericMethod( entityType, type ).Invoke( null, new object[]{ ret, props });
            //bug. Don't know how to implement it right
            //GetParsers<T, string>( ret, props );
            //GetParsers<T, int>( ret, props );
            //GetParsers<T, int?>( ret, props );
            //GetParsers<T, uint>( ret, props );
            //GetParsers<T, uint?>( ret, props );
            //GetParsers<T, long>( ret, props );
            //GetParsers<T, long?>(ret, props);
            //GetParsers<T, ulong>(ret, props);
            //GetParsers<T, ulong?>(ret, props);
            //GetParsers<T, byte>( ret, props );
            //GetParsers<T, byte?>( ret, props );
            //GetParsers<T, bool>( ret, props );
            //GetParsers<T, bool?>( ret, props );
            //GetParsers<T, ushort>( ret, props );
            //GetParsers<T, ushort?>( ret, props );
            return ret;
        }
        public static string ConvertName( string name ) {
            var t = new StringBuilder();
            t.Append( Char.ToLower( name[ 0 ] ) );
            for ( var index = 1; index < name.Length; index++ ) {
                var c = name[ index ];
                //add '_' b4 numbers and captials 
                if ( Char.IsUpper( c ) || ( Char.IsNumber( c ) && !Char.IsNumber( name[ index - 1 ] ) ) ) {
                    t.Append( '_' );
                    t.Append( Char.ToLower( c ) );
                }
                else t.Append( c );
            }
            return t.ToString();
        }
    }
}
