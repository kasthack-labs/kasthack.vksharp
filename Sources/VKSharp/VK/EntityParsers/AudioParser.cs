using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class AudioParser : IVKEntityParser<Audio> {
        private static readonly Lazy<AudioParser> Lazy = new Lazy<AudioParser>( () => new AudioParser() );
        public static AudioParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        public Audio ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Audio[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
