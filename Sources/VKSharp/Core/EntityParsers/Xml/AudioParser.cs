using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AudioParser : IXmlVKEntityParser<Audio> {
        public IExecutor Executor { get; set; }
        private static readonly Lazy<AudioParser> Lazy = new Lazy<AudioParser>( () => new AudioParser() );
        public static AudioParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private AudioParser() {}

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Audio entity) {
            throw new NotImplementedException();
        }

        public Audio ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Audio[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Audio ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Audio entity) {
            throw new NotImplementedException();
        }

    }
}
