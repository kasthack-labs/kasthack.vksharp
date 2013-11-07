using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class AudioParser : IVKEntityParser<Audio> {
        private static readonly Lazy<AudioParser> Lazy = new Lazy<AudioParser>( () => new AudioParser() );
        public static AudioParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private AudioParser() {}

        public Audio ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Audio[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
