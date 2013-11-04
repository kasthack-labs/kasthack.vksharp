using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class AudioParser : IVKEntityParser<Audio> {
        private static readonly Lazy<AudioParser> Lazy = new Lazy<AudioParser>( () => new AudioParser() );
        public static AudioParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private AudioParser() {}

        public Audio ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Audio[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
