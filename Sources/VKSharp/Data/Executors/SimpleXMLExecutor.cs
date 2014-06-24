using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Exceptions;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        #region Helper classes
        //parser generator for subentities
        private class PropertyMapper<TProperty> where TProperty : IVKEntity<TProperty> {
            internal Action<TParentEntity, XElement> GetPropertyParser<TParentEntity>( PropertyInfo p, SimpleXMLExecutor context ) {
                var tp = typeof( TProperty );
                if ( tp != p.PropertyType ) throw new InvalidOperationException( "Wrong TProperty type" );
                var parser = context.GetParser<TProperty>();
                var sd = (Action<TParentEntity, TProperty>)
                    Delegate.CreateDelegate( typeof( Action<TParentEntity, TProperty> ), null, p.GetSetMethod() );
                return ( item, node ) => sd( item, parser.ParseFromXml( node ) );
            }
        }

        private class TypeIfacePair {
            private readonly Type _iface;
            private readonly Type _type;

            public TypeIfacePair( Type type, Type iface ) {
                this._type = type;
                this._iface = iface;
            }

            public Type Type {
                get {
                    return this._type;
                }
            }

            public Type Iface {
                get {
                    return this._iface;
                }
            }
        }
        #endregion

        //extension for raw reqs to vk
        private const string ReqExt = "xml";
        //current assembly
        private static readonly Lazy<Assembly> CurrentAssemblyLazy =
            new Lazy<Assembly>( () => Assembly.GetAssembly( typeof( SimpleXMLExecutor ) ) );

        //definitons of generic parser
        //key : generic type def
        //value : generic parser def
        private Dictionary<Type, Type> _parserGenericStor;
        //parsers
        private Dictionary<Type, object> _parserStor;

        #region Parser loader
        //lock object for init
        private static readonly object locker = (uint?) 0;
        //loads parsers
        //fills _parserGenericStor & _parserStor
        private void LoadParsers() {
            //reflection magic
            lock ( locker ) {
                try {
                    // Get all classes impelmenting IXmlVKEntityParser<T>
                    // with public constructore
                    // from VKSharp.Core.EntityParsers.Xml namespase
                    var typesXml = GetTypesXml();
                    var typesParser = GetTypesParser( typesXml );
                    var types = typesParser;
                    // add generic parsers to stor
                    this._parserGenericStor =
                        types.Where( a => a.Iface.IsGenericType && a.Iface.GenericTypeArguments[ 0 ].IsGenericType )
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
                    this._parserStor = dictionary;
                }
                catch ( Exception ex ) {
                    Console.WriteLine( ex.Message );
                    throw;
                }
            }
        }

        private static IEnumerable<TypeIfacePair> GetTypesParser( IEnumerable<Type> typesXml ) {
            return
                typesXml.Select( a => new TypeIfacePair( a, a.GetInterface( "IXmlVKEntityParser`1" ) ) )
                        .Where( a => a.Iface != null )
                        .ToArray();
        }

        private static IEnumerable<Type> GetTypesXml() {
            return CurrentAssemblyLazy.Value.GetTypes()
                .Where( t => String.Equals( t.Namespace, "VKSharp.Core.EntityParsers.Xml", StringComparison.Ordinal ) )
                .ToArray();
        }
        #endregion

        //wrappers
        private Dictionary<Type, object> ParserStor {
            get {
                if ( this._parserStor == null )
                    this.LoadParsers();
                return this._parserStor;
            }
        }

        private Dictionary<Type, Type> ParserGenericStor {
            get {
                if ( this._parserGenericStor == null )
                    this.LoadParsers();
                return this._parserGenericStor;
            }
        }

        //private Dictionary<> 
        //get subentity parsers
        //TODO:implement GetSubentityParsers
        public Dictionary<string, Action<TParentEntity, XElement>> GetSubentityParsers<TParentEntity>()
            where TParentEntity : IVKEntity<TParentEntity> {
            var ti = typeof( TParentEntity );

            var props = ti.GetProperties( BindingFlags.Instance | BindingFlags.Public );

            var pm = typeof( PropertyMapper<> ).GetGenericTypeDefinition().MakeGenericType( ti );

            throw new NotImplementedException();
        }

        //takes parser instanse from ParserStor
        //if parser is generic => creates instanse of it
        public IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T> {
            object parser;
            var ti = typeof( T );
            IXmlVKEntityParser<T> p2;
            if ( this.GetParserForT<T>( ti, out parser ) ) {
                p2 = (IXmlVKEntityParser<T>) parser;
                p2.Executor = p2.Executor ?? this;
                this.ParserStor.Add( ti, p2 );
            }
            else
                p2 = (IXmlVKEntityParser<T>) parser;
            return p2;
        }

        //returns <was parser created or taken from cache>
        private bool GetParserForT<T>( Type ti, out object parser ) {
            if ( this.ParserStor.TryGetValue( ti, out parser ) )
                return false;
            Type parserGTD;
            if ( !ti.IsGenericType || !this.ParserGenericStor.TryGetValue( ti.GetGenericTypeDefinition(), out parserGTD ) )
                throw new Exception( "No such parser" );
            parser = Activator.CreateInstance( parserGTD.MakeGenericType( ti.GenericTypeArguments[ 0 ] ) );
            return true;
        }

        #region IExecutor
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            return this.ParseResponse<T>( await this.ExecRawAsync( request ) );
        }

        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            return await ParserHelper.ExecRawAsync( request, ReqExt );
        }

        public VKResponse<T> ParseResponse<T>( string input ) where T : IVKEntity<T> {
            return this.ParseResponseXml<T>( XDocument.Parse( input ) );
        }

        public VKResponse<T> ParseResponseXml<T>( XDocument doc ) where T : IVKEntity<T> {
            var rootNode = doc.Root;
            if ( rootNode.Name.ToString() == "error" )
                throw new VKException( rootNode.Element( "error_msg" ).Value );
            var parser = this.GetParser<T>();
            var lattr = rootNode.Attribute( "list" );
            //list=true||1 element => std parser, else fragments
            var uarr = ( lattr != null && lattr.Value == "true" ) || rootNode.Elements().Take( 2 ).Count() == 1;
            return new VKResponse<T> {
                Data = uarr ? parser.ParseAllFromXml( rootNode.Elements() ) : new[] { parser.ParseFromXmlFragments( rootNode.Elements() ) },
                Status = null
            };
        }

        public void AttachParser<T>( T defaultParser ) where T : IXmlVKEntityParser { throw new NotImplementedException(); }
        #endregion
    }
}