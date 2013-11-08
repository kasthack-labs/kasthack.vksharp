using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EpicMorg.Net;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Request;
using VKSharp.Helpers;

namespace VKSharp.Data.Executors {
    public class SimpleXMLExecutor : IExecutor {
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T>, new() {
            var doc = new XmlDocument();
            var raw = await this.ExecRawAsync( request );
            doc.LoadXml( raw );
            var rootNode = doc.DocumentElement;
            if ( rootNode.HasAttribute( "list" ) && rootNode.Attributes[ "list" ].Value.ToLower(BuiltInData.Instance.NC) == "true" ) {
                return new VKResponse<T> {
                    Data = ( (IVKEntity<T>) ( new T() ) )
                            .GetParser()
                            .ParseAllFromXml( rootNode.ChildNodes.OfType<XmlNode>() ),
                    Status = null
                };
            }
            return new VKResponse<T> {
                Data = new[]{( (IVKEntity<T>) ( new T() ) )
                        .GetParser()
                        .ParseFromXmlFragments( rootNode.ChildNodes.OfType<XmlNode>() )},
                Status = null
            };
        }

        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T>, new() {
            var bID = Helpers.BuiltInData.Instance;
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
