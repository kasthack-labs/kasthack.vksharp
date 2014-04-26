using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.EntityParsers.Xml;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Exceptions;
using VKSharp.Helpers.Parsers;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        #region Helper classes
        //parser generator for subentities
        private class PropertyMapper<TProperty> where TProperty : IVKEntity<TProperty> {
            internal Action<TParentEntity, XElement> GetPropertyParser<TParentEntity>(
                PropertyInfo p,
                SimpleXMLExecutor context ) {
                var tp = typeof( TProperty );
                if ( tp != p.PropertyType )
                    throw new InvalidOperationException( "Wrong TProperty type" );
                //Func<XElement, TProperty> pd =
                //    ( a ) => ( context.GetParser<TProperty>() ).ParseFromXml( a );
                var parser = context.GetParser<TProperty>();
                var sd = (Action<TParentEntity, TProperty>) Delegate.CreateDelegate(
                        typeof( Action<TParentEntity, TProperty> ),
                        null,
                        p.GetSetMethod()
                    );
                //if (Attribute.IsDefined( p, typeof(FlatMap) )){
                //    throw new NotImplementedException();
                //    //multiple keys req
                //    var gd = (Func<TParentEntity, TProperty>) Delegate.CreateDelegate(
                //        typeof( Action<TParentEntity, TProperty> ),
                //        null,
                //        p.GetGetMethod()
                //    );
                //}
                //else {
                    
                    return ( item, node ) => sd( item, parser.ParseFromXml( node ) );
                //}
            }
        }

        private class TypeIfacePair {
            private readonly Type _type;
            private readonly Type _iface;

            public Type Type {
                get { return _type; }
            }

            public Type Iface {
                get { return _iface; }
            }

            public TypeIfacePair( Type type, Type iface ) {
                this._type = type;
                this._iface = iface;
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
        //value : gereric parser def
        private Dictionary<Type, Type> _parserGenericStor;
        //parsers
        private Dictionary<Type, object> _parserStor;
        #region Parser loader
        //lock object for init
        private static object locker = (uint?) 0;
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
                    _parserGenericStor = types.Where( a => a.Iface.IsGenericType
                            && a.Iface
                                .GenericTypeArguments[ 0 ]
                                .IsGenericType
                        )
                        .ToDictionary(
                        a => a
                            .Iface
                            .GenericTypeArguments[ 0 ]
                            .GetGenericTypeDefinition(),
                        a => a
                            .Type
                            .GetGenericTypeDefinition()
                    );
                    // create instanses of all non-generic parsers
                    // & attach them to current SimpleXmlParser
                    // & add to Dictionary<typeof(type),parser<Type> 
                    var dictionary = types
                        .Where( a => !a.Type.IsGenericType )
                        .Where( a => a
                            .Type
                            .GetConstructor( Type.EmptyTypes ) != null
                        )
                        .ToDictionary(
                            a => a.Iface.GetGenericArguments()[ 0 ],
                            a => Activator.CreateInstance( a.Type )
                        );
                    foreach ( var xmlVKEntityParser in dictionary
                        .Values
                        .OfType<IXmlVKEntityParser>()
                    )
                        xmlVKEntityParser.Executor = this;
                    _parserStor = dictionary;
                    foreach ( var o in PrimitiveParserFactory
                        .ParserLazy
                        .Value
                    )
                        _parserStor.Add( o.Key, o.Value );
                }
                catch ( Exception ex ) {
                    Console.WriteLine( ex.Message );
                    throw;
                }

            }
        }
        private static TypeIfacePair[] GetTypesParser( IEnumerable<Type> typesXml ) {
            return typesXml.Select( a => new TypeIfacePair( a, a.GetInterface( "IXmlVKEntityParser`1" ) ) )
                .Where( a => a.Iface != null )
                .ToArray();
        }
        private static IEnumerable<Type> GetTypesXml() {
            return CurrentAssemblyLazy
                .Value
                .GetTypes()
                .Where(
                    t =>
                    String.Equals(
                        t.Namespace,
                        "VKSharp.Core.EntityParsers.Xml",
                        StringComparison.Ordinal
                        )
                )
                .ToArray();
        }
        #endregion
        //wrappers
        private Dictionary<Type, object> ParserStor {
            get {
                if ( _parserStor == null ) LoadParsers();
                return _parserStor;
            }
        }
        private Dictionary<Type, Type> ParserGenericStor {
            get {
                if ( _parserGenericStor == null ) LoadParsers();
                return _parserGenericStor;
            }
        }
        //private Dictionary<> 
        //get subentity parsers
        public Dictionary<string, Action<TParentEntity, XElement>> GetSubentityParsers<TParentEntity>()
        where TParentEntity:IVKEntity<TParentEntity> {
            var ti = typeof( TParentEntity );

            var props = ti.GetProperties( BindingFlags.Instance | BindingFlags.Public );
            
            var pm = typeof (PropertyMapper<>).GetGenericTypeDefinition().MakeGenericType( ti );

            throw  new NotImplementedException();
        }

        //takes parser instanse from ParserStor
        //if parser is generic => creates instanse of it
        public IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T> {
            object parser;
            var ti = typeof( T );
            IXmlVKEntityParser<T> p2;
            if ( GetParserForT( ti, out parser ) ) {
                p2 = (IXmlVKEntityParser<T>) parser;
                p2.Executor = p2.Executor ?? this;
                this.ParserStor.Add( ti, p2 );
            }
            else p2 = (IXmlVKEntityParser<T>) parser;
            return p2;
        }
        ///returns <was parser created or taken from cache>
        private bool GetParserForT( Type ti, out object parser ) {
            if ( this.ParserStor.TryGetValue( ti, out parser ) ) return false;
            Type parserGTD;
            if (
                !ti.IsGenericType
                ||
                !this.ParserGenericStor.TryGetValue(
                    ti.GetGenericTypeDefinition(),
                    out parserGTD
                )
            )
                throw new Exception( "No such parser" );
            parser = Activator.CreateInstance(
                parserGTD.MakeGenericType( ti.GenericTypeArguments[ 0 ] )
            );
            return true;
        }
        
        #region IExecutor
        public VKResponse<T> ParseResponse<T>( string input )
            where T : IVKEntity<T> {
            return ParseResponseXml<T>( XDocument.Parse( input ) );
        }

        public VKResponse<T> ParseResponseXml<T>( XDocument doc ) where T : IVKEntity<T> {
            var rootNode = doc.Root;
            if ( rootNode.Name.ToString() == "error" )
                throw new VKException( rootNode.Element( "error_msg" ).Value );
            var parser = GetParser<T>();
            var _l = rootNode.Attribute( "list" );
            return new VKResponse<T> {
                Data = (
                            _l != null
                            &&
                            _l.Value.ToLower( BuiltInData.Instance.NC ) == "true"
                        )
                        ? parser.ParseAllFromXml( rootNode.Elements() )
                        : new[] {
                            parser.ParseFromXmlFragments( rootNode.Elements() )
                        },
                Status = null
            };
        }

        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            return this.ParseResponse<T>( await this.ExecRawAsync( request ) );
        }

        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            return await ParserHelper.ExecRawAsync( request, ReqExt );
        }

        public void AttachParser<T>( T defaultParser ) where T:IXmlVKEntityParser {
            throw new NotImplementedException();
        }
        #endregion
    }
}
