using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AudioParser : IXmlVKEntityParser<Audio> {
        public IExecutor Executor { get; set; }

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

        public void UpdateFromFragment( XmlNode node, Audio entity ) {
            switch ( node.Name ) {
                case "id":
                    entity.ID = ulong.Parse( node.InnerText );
                    break;
                case "owner_id":
                    entity.OwnerID = int.Parse( node.InnerText );
                    break;
                case "album_id":
                    entity.OwnerID = int.Parse( node.InnerText );
                    break;
                case "artist":
                    entity.Artist = node.InnerText;
                    break;
                case "title":
                    entity.Title = node.InnerText;
                    break;
                case "duration":
                    entity.Duration = uint.Parse( node.InnerText );
                    break;
                case "url":
                    entity.Url = node.InnerText;
                    break;
                case "lyrics_id":
                    entity.LyricsID = int.Parse( node.InnerText );
                    break;
                case "genre_id":
                    entity.Genre = (AudioGenre) int.Parse( node.InnerText );
                    break;
            }
        }

    }
}
