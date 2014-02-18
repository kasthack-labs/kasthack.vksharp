using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Parsers;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        private const string _reqExt = "xml";
        private static readonly Lazy<Assembly> CurrentAssemblyLazy = new Lazy<Assembly>( () => Assembly.GetAssembly( typeof( SimpleXMLExecutor ) ) );
        private Dictionary<Type, Type> _parserGenericStor;
        private Dictionary<Type, object> _parserStor;
        private void LoadParsers(){
            //reflection magic
            try {
                var types = CurrentAssemblyLazy
                        .Value
                        .GetTypes()
                        .Where(
                            t =>
                            String.Equals( t.Namespace, "VKSharp.Core.EntityParsers.Xml", StringComparison.Ordinal ) )
                        .Select( a => new {
                            Type=a,
                            Iface = a.GetInterface( "IXmlVKEntityParser`1" )
                        } )
                        .Where( a => a.Iface != null )
                        .ToArray();
                _parserGenericStor = types.Where( a => a.Type.IsGenericType ).ToDictionary(
                    a=>a.Iface.GenericTypeArguments[0].GetGenericTypeDefinition(),
                    a=>a.Type.GetGenericTypeDefinition()
                );
                _parserStor = types.Where( a=>!a.Type.IsGenericType )
                        .ToDictionary(
                            a => a.Iface.GetGenericArguments()[0],
                            a => Activator.CreateInstance( a.Type )
                        );
                foreach ( var o in PrimitiveParserFactory.ParserLazy.Value ){
                    _parserStor.Add( o.Key, o.Value );
                }
            }
            catch ( Exception ex ) {
                Console.WriteLine( ex.Message );
                throw;
            }
        }

        private Dictionary<Type, object> ParserStor {
            get {
                if (_parserStor==null) LoadParsers();
                return _parserStor;
            }
        }

        private Dictionary<Type, Type> ParserGenericStor {
            get {
                if (_parserGenericStor==null) LoadParsers();
                return _parserGenericStor;
            }
        }

        private IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T>  {
            object parser;
            Type parserGTD, ti = typeof( T );
            if ( ParserStor.TryGetValue( ti, out parser ) ) {
                var p = (IXmlVKEntityParser<T>) parser;
                p.Executor = p.Executor ?? this;
                return p;
            }
            if ( !ti.IsGenericType || !this.ParserGenericStor.TryGetValue( ti.GetGenericTypeDefinition(), out parserGTD ) )
                throw new Exception( "No such parser" );
            parser = Activator.CreateInstance( parserGTD.MakeGenericType( ti.GenericTypeArguments[0] ) );
            var p2 = (IXmlVKEntityParser<T>) parser;
            p2.Executor = p2.Executor ?? this;
            this.ParserStor.Add( ti, p2 );
            return p2;
        }

        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            var doc = new XmlDocument();
            var raw = await this.ExecRawAsync( request);
            doc.LoadXml( raw );
            var rootNode = doc.DocumentElement;
            var parser = GetParser<T>();
            return new VKResponse<T> {
                Data = ( rootNode.HasAttribute( "list" )
                      && rootNode.Attributes[ "list" ].Value.ToLower( BuiltInData.Instance.NC ) == "true" )
                        ? parser.ParseAllFromXml( rootNode.ChildNodes.OfType<XmlNode>() )
                        : new[] {
                            parser.ParseFromXmlFragments( rootNode.ChildNodes.OfType<XmlNode>() )
                        },
                Status = null
            };
        }

        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            return await ParserHelper.ExecRawAsync( request, _reqExt );
        }
    }
}
