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
        private static readonly Lazy<Dictionary<Type, object>> ParserStorLazy = new Lazy<Dictionary<Type, object>>( () => {
            //reflection magic
            try {
                var dic =
                    Assembly.GetAssembly( typeof( SimpleXMLExecutor ) )
                        .GetTypes()
                        .Where( t => String.Equals( t.Namespace, "VKSharp.Core.EntityParsers.Xml", StringComparison.Ordinal ) )
                        .Where( a=>!a.IsGenericType )
                        .Select( a => new {
                            InstanceProperty = a.GetProperty( "Instanse", BindingFlags.Static | BindingFlags.Public ),
                            Iface = a.GetInterface( "IXmlVKEntityParser`1" )
                        } )
                        .Where( a => a.InstanceProperty != null && a.Iface != null )
                        .ToDictionary(
                            a => a.Iface.GetGenericArguments()[0],
                            a => a.InstanceProperty.GetValue( null, null )
                        );
                foreach ( var o in PrimitiveParserFactory.ParserLazy.Value )
                    dic.Add( o.Key, o.Value );
                return dic;
            }
            catch ( Exception ex ) {
                Console.WriteLine( ex.Message );
                throw;
            }
        } );

        private static Dictionary<Type, object> ParserStor {
            get {
                return ParserStorLazy.Value;
            }
        }

        private static IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T>  {
            object parser;
            var ti = typeof( T );
            if ( ParserStor.TryGetValue( ti, out parser ) )
                return (IXmlVKEntityParser<T>) parser;
            throw new Exception( "No such parser" );
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
