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
    public partial class SimpleXMLExecutor : IExecutor {
        private const string ReqExt = "xml";
        #region IO
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
        #endregion
        #region IExecutor
        public async Task<VKResponse<T>> ExecAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> => ParseResponse<T>( await ExecRawAsync( request ) );
        public async Task<string> ExecRawAsync<T>( VKRequest<T> request ) where T : IVKEntity<T> => await ExecRawAsync( request, ReqExt );
        public VKResponse<T> Parse<T>( string input ) where T : IVKEntity<T> => ParseResponse<T>( input );

        public VKResponse<T> ParseResponse<T>( string input ) where T : IVKEntity<T> => ParseResponseXml<T>( XDocument.Parse( input ) );

        public VKResponse<T> ParseResponseXml<T>( XDocument doc ) where T : IVKEntity<T> {
            var rootNode = doc.Root;
            if ( rootNode.Name.ToString() == "error" )
                throw new VKException( rootNode.Element( "error_msg" ).Value );
            //var parser = GetParser<T>();
            //var lattr = rootNode.Attribute( "list" );
            ////list=true||1 element => std parser, else fragments
            //var uarr = ( lattr != null && lattr.Value == "true" ) || rootNode.Elements().Take( 2 ).Count() == 1;
            //return new VKResponse<T> {
            //    Data = uarr ? parser.ParseAllFromXml( rootNode.Elements() ) : new[ ] { parser.ParseFromXmlFragments( rootNode.Elements() ) },
            //    Status = null
            //};
            return null;
        }


        public void AttachParser<T>( T defaultParser ) where T : IXmlVKEntityParser => defaultParser.Executor = this;
        #endregion
    }
}