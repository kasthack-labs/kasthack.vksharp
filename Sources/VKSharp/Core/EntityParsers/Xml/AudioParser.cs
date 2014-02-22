using System;
using System.Xml;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AudioParser : DefaultParser<Audio> {
        public override bool UpdateFromFragment( XElement node, Audio entity ) {
            Action<Audio, string> parser;
            var nodeName = node.Name.ToString();
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.Value );
                return true;
            }
            switch ( nodeName ) {
                case "genre_id":
                    entity.Genre = (AudioGenre) int.Parse( node.Value );
                    break;
                default:
                    return false;
            }
            return true;
        }

    }
}
