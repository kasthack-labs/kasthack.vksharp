using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AudioParser : IXmlVKEntityParser<Audio> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<Audio, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<Audio, string>>>( ParserHelper.GetStringParsers<Audio> );

        private static Dictionary<string, Action<Audio, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml( IEnumerable<XmlNode> nodes, Audio entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public Audio ParseFromXml( XmlNode node ) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public Audio[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public Audio ParseFromXmlFragments( IEnumerable<XmlNode> nodes ) {
            var sc = new Audio();
            this.FillFromXml( nodes, sc );
            return sc;
        }

        public bool UpdateFromFragment( XmlNode node, Audio entity ) {
            Action<Audio, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            switch ( node.Name ) {
                case "genre_id":
                    entity.Genre = (AudioGenre) int.Parse( node.InnerText );
                    break;
                default:
                    return false;
            }
            return true;
        }

    }
}
