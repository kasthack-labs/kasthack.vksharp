using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.EntityFragments;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class ProfilePhotosParser : IXmlVKEntityParser<ProfilePhotos> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<ProfilePhotos, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<ProfilePhotos, string>>>( ParserHelper.GetStringParsers<ProfilePhotos> );

        private static Dictionary<string, Action<ProfilePhotos, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, ProfilePhotos entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public ProfilePhotos ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public ProfilePhotos[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public ProfilePhotos ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var sc = new ProfilePhotos();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, ProfilePhotos entity ) {
            Action<ProfilePhotos, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }

    }
}
