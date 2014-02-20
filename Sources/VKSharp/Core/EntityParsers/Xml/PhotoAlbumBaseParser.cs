﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PhotoAlbumBaseParser : IXmlVKEntityParser<PhotoAlbumBase> {
        public IExecutor Executor { get; set; }

        private static Lazy<Dictionary<string, Action<PhotoAlbumBase, string>>> _generatedParsers =
            new Lazy<Dictionary<string, Action<PhotoAlbumBase, string>>>( ParserHelper.GetStringParsers<PhotoAlbumBase> );

        private static Dictionary<string, Action<PhotoAlbumBase, string>> GeneratedParsers {
            get {
                return _generatedParsers.Value;
            }
        }

        public void FillFromXml(IEnumerable<XmlNode> nodes, PhotoAlbumBase entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public PhotoAlbumBase ParseFromXml(XmlNode node) {
            return this.ParseFromXmlFragments( node.ChildNodes.OfType<XmlNode>() );
        }

        public PhotoAlbumBase[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public PhotoAlbumBase ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new PhotoAlbumBase();
            this.FillFromXml( nodes, sc );
            return sc;
        }
        public bool UpdateFromFragment( XmlNode node, PhotoAlbumBase entity ) {
            Action<PhotoAlbumBase, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            return false;
        }
    }
}
