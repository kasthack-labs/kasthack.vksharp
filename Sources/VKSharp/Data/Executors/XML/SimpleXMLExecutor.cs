using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Exceptions;
/*
    How does parser generation work.

    STEP 1: Init
        1. Loads all types implementing IXmlVKEntityParser<T> from VKSharp.Core.EntityParsers.Xml 
        2. If T is generic -> add parser generic definition to GenericStor
           else create instanse of parser via reflection, attach it to current Executor & add it ParserStor
    STEP 2. On request( GetParser<T>)
        1. We have requested parser?
            Yes -> return
        2. T is generic?
            No -> throw "No such parser"
        3. We have generic parser definition for T<>?
            No -> throw "No such parser"
        4. Generate Parser<T<T2>> & add to ParserStor
        5. return
*/
namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        #region Helper classes
        //parser generator for subentities
        private class PropertyMapper<TProperty> where TProperty : IVKEntity<TProperty> {
            internal Action<TParentEntity, XElement> GetPropertyParser<TParentEntity>( PropertyInfo p, SimpleXMLExecutor context ) {
                var tp = typeof(TProperty);
                if ( tp != p.PropertyType ) throw new InvalidOperationException( "Wrong TProperty type" );
                var parser = context.GetParser<TProperty>();
                var sd = (Action<TParentEntity, TProperty>)
                    Delegate.CreateDelegate( typeof(Action<TParentEntity, TProperty>), null, p.GetSetMethod() );
                return ( item, node ) => sd( item, parser.ParseFromXml( node ) );
            }
        }

        private class TypeIfacePair {
            public TypeIfacePair( Type type, Type iface ) {
                Type = type;
                Iface = iface;
            }

            public Type Type { get; }

            public Type Iface { get; }
        }
        #endregion

        //extension for raw reqs to vk
        private const string ReqExt = "xml";
        //current assembly
        private static readonly Lazy<Assembly> CurrentAssemblyLazy = new Lazy<Assembly>( () => Assembly.GetAssembly( typeof(SimpleXMLExecutor) ) );

        //definitons of generic parser
        //key : generic type def
        //value : generic parser def
        private Dictionary<Type, Type> _parserGenericStor;
        //parsers
        //key: target type
        //value: parser<T>
        private Dictionary<Type, object> _parserStor;

        #region Parser loader
        //lock object for init
        private static readonly object Locker = new object();
        //loads parsers
        //fills _parserGenericStor & _parserStor
        private void LoadParsers() {
            //reflection magic
            lock (Locker) {
                try {
                    // Get all classes impelmenting IXmlVKEntityParser<T>
                    // with public constructore
                    // from VKSharp.Core.EntityParsers.Xml namespase
                    var types = GetTypesParser( GetTypesXml() );
                    // add generic parsers to stor
                    _parserGenericStor = types.Where( a => a.Iface.IsGenericType && a.Iface.GenericTypeArguments[ 0 ].IsGenericType )
                             .ToDictionary(
                                 a => a.Iface.GenericTypeArguments[ 0 ].GetGenericTypeDefinition(),
                                 a => a.Type.GetGenericTypeDefinition() );
                    // create instanses of all non-generic parsers
                    // & attach them to current SimpleXmlParser
                    // & add to Dictionary<typeof(type),parser<Type> 
                    var dictionary =
                        types.Where( a => !a.Type.IsGenericType )
                             .Where( a => a.Type.GetConstructor( Type.EmptyTypes ) != null )
                             .ToDictionary( a => a.Iface.GetGenericArguments()[ 0 ], a => Activator.CreateInstance( a.Type ) );
                    foreach ( var xmlVkEntityParser in dictionary.Values.OfType<IXmlVKEntityParser>() )
                        xmlVkEntityParser.Executor = this;
                    _parserStor = dictionary;
                }
                catch ( Exception ex ) {
                    Console.WriteLine( ex.Message );
                    throw;
                }
            }
        }

        private static IEnumerable<TypeIfacePair> GetTypesParser( IEnumerable<Type> typesXml ) =>
            typesXml.Select( a => new TypeIfacePair( a, a.GetInterface( "IXmlVKEntityParser`1" ) ) ).Where( a => a.Iface != null ).ToArray();

        private static IEnumerable<Type> GetTypesXml() =>
            CurrentAssemblyLazy.Value.GetTypes().Where( t => String.Equals( t.Namespace, "VKSharp.Core.EntityParsers.Xml", StringComparison.Ordinal ) ).ToArray();
        #endregion

        //wrappers
        private Dictionary<Type, object> ParserStor {
            get {
                if ( _parserStor == null ) LoadParsers();
                return _parserStor;
            }
        }
        //generic parser definitions
        private Dictionary<Type, Type> ParserGenericStor {
            get {
                if ( _parserGenericStor == null ) LoadParsers();
                return _parserGenericStor;
            }
        }

        //takes parser instanse from ParserStor
        //if parser is generic => creates instanse of it
        public IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T> {
            object parser;
            var ti = typeof(T);
            IXmlVKEntityParser<T> p2;
            if ( !GetParserForT<T>( ti, out parser ) ) p2 = (IXmlVKEntityParser<T>) parser;
            else {
                p2 = (IXmlVKEntityParser<T>) parser;
                p2.Executor = p2.Executor ?? this;
                ParserStor.Add( ti, p2 );
            }
            return p2;
        }

        //returns <was parser created or taken from cache>
        private bool GetParserForT<T>( Type ti, out object parser ) {
            if ( ParserStor.TryGetValue( ti, out parser ) )
                return false;
            Type parserGTD;
            if ( !ti.IsGenericType || !ParserGenericStor.TryGetValue( ti.GetGenericTypeDefinition(), out parserGTD ) )
                throw new Exception( "No such parser" );
            parser = Activator.CreateInstance( parserGTD.MakeGenericType( ti.GenericTypeArguments[ 0 ] ) );
            return true;
        }

        private static readonly HttpClient Client = new HttpClient();
        private static async Task<string> ExecRawAsync<T>( VKRequest<T> request, string format )
            where T : IVKEntity<T> {

            var ps = request.Parameters.ToList();
            ps.Add( new KeyValuePair<string, string>( "v", "5.21" ) );
            ps.Add( new KeyValuePair<string, string>( "https", "1" ) );
            var path = "/method/" + request.MethodName + "." + format;
            if ( request.Token != null )
                ps.Add( new KeyValuePair<string, string>( "access_token", request.Token.Token ) );
            return await ( await Client.PostAsync(
                new Uri( BuiltInData.Instance.VkDomain + path ),
                new FormUrlEncodedContent( ps )
            ) ).Content.ReadAsStringAsync();
        }
        #region IExecutor
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> => ParseResponse<T>( await ExecRawAsync( request ) );
        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> => await ExecRawAsync( request, ReqExt );
        public VKResponse<T> Parse<T>( string input ) where T : IVKEntity<T> => ParseResponse<T>( input );

        public VKResponse<T> ParseResponse<T>( string input ) where T : IVKEntity<T> => ParseResponseXml<T>( XDocument.Parse( input ) );

        public VKResponse<T> ParseResponseXml<T>( XDocument doc ) where T : IVKEntity<T> {
            var rootNode = doc.Root;
            if ( rootNode.Name.ToString() == "error" )
                throw new VKException( rootNode.Element( "error_msg" ).Value );
            var parser = GetParser<T>();
            var lattr = rootNode.Attribute( "list" );
            //list=true||1 element => std parser, else fragments
            var uarr = ( lattr != null && lattr.Value == "true" ) || rootNode.Elements().Take( 2 ).Count() == 1;
            return new VKResponse<T> {
                Data = uarr ? parser.ParseAllFromXml( rootNode.Elements() ) : new[ ] { parser.ParseFromXmlFragments( rootNode.Elements() ) },
                Status = null
            };
        }


        public void AttachParser<T>( T defaultParser ) where T : IXmlVKEntityParser => defaultParser.Executor = this;
        #endregion
    }
}