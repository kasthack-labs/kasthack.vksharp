using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EpicMorg.Net;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        private static readonly Lazy<Dictionary<Type, object>> ParserStorLazy = new Lazy<Dictionary<Type, object>>(() => 
        new Dictionary<Type, object>() );

        private static Dictionary<Type, object> ParserStor {
            get {
                return ParserStorLazy.Value;
            }
        }

        private static IXmlVKEntityParser<T> GetParser<T>() where T : IVKEntity<T>, new() {
            object parser;
            var ti = typeof( T );
            if ( ParserStor.TryGetValue( ti, out parser ) )
                return (IXmlVKEntityParser<T>) parser;
            if (!ti.IsGenericType)
                throw new Exception();
            if ( ti.GetGenericTypeDefinition() == typeof (StructEntity<>) ) {
                //ParserStor.Add(ti, ti.IsGenericTypeDefinition
            }
            return null;
        }

        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T>, new() {
            var doc = new XmlDocument();
            var raw = await this.ExecRawAsync( request );
            doc.LoadXml( raw );
            var rootNode = doc.DocumentElement;
            var parser = GetParser<T>();
            if ( rootNode.HasAttribute( "list" ) && rootNode.Attributes[ "list" ].Value.ToLower(BuiltInData.Instance.NC) == "true" ) {
                return new VKResponse<T> {
                    Data =  parser
                            .ParseAllFromXml( rootNode.ChildNodes.OfType<XmlNode>() ),
                    Status = null
                };
            }
            return new VKResponse<T> {
                Data = new[]{parser
                        .ParseFromXmlFragments( rootNode.ChildNodes.OfType<XmlNode>() )},
                Status = null
            };
        }

        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T>, new() {
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
