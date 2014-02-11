using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EpicMorg.Net;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.Parsers;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        private readonly Lazy<Assembly> CurrentAssemblyLazy = new Lazy<Assembly>( () => Assembly.GetAssembly( typeof( SimpleXMLExecutor ) ) );
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
                            InstanceProperty = GetParserInstanseProperty(a),
                            Iface = a.GetInterface( "IXmlVKEntityParser`1" )
                        } )
                        .Where( a => a.InstanceProperty != null && a.Iface != null )
                        .ToArray();
                _parserGenericStor = types.Where( a => a.Type.IsGenericType ).ToDictionary(
                    a=>a.Iface.GenericTypeArguments[0].GetGenericTypeDefinition(),
                    a=>a.Type.GetGenericTypeDefinition()
                );
                _parserStor = types.Where( a=>!a.Type.IsGenericType )
                        .ToDictionary(
                            a => a.Iface.GetGenericArguments()[0],
                            a => a.InstanceProperty.GetValue( null, null )
                        );
                foreach ( var o in PrimitiveParserFactory.ParserLazy.Value )
                    _parserStor.Add( o.Key, o.Value );
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
            var ti = typeof( T );
            if (ParserStor.TryGetValue( ti, out parser ) )
                return (IXmlVKEntityParser<T>) parser;
            if ( ti.IsGenericType ) {
                var tiG = ti.GetGenericTypeDefinition();
                Type parserGTD;
                if ( ParserGenericStor.TryGetValue( tiG, out parserGTD ) ) {
                    var parserTD = parserGTD.MakeGenericType( ti.GenericTypeArguments[0] );
                    parser = GetParserInstanseProperty( parserTD ).GetValue( null, null );
                    ParserStor.Add( ti, parser );
                    return (IXmlVKEntityParser<T>) parser;
                }
            }
            throw new Exception( "No such parser" );
        }

        private static PropertyInfo GetParserInstanseProperty( Type parserTD ) {
            return parserTD.GetProperty( "Instanse", BindingFlags.Static | BindingFlags.Public );
        }

        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> {
            var doc = new XmlDocument();
            var raw = await this.ExecRawAsync( request );
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
            var bID = BuiltInData.Instance;
            var vk = bID.VKDomain;
            var query = String.Join( "&", request.Parameters.Select( a => a.Key + "=" + a.Value ) );
            var queryB = new StringBuilder();
            queryB.Append( "/method/" );
            queryB.Append( request.MethodName );
            queryB.Append( @".xml" );
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
                AWC.RequestMethod.POST,
                query,
                40000
            );
        }
    }
}
