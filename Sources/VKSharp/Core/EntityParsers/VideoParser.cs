using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class VideoParser : IVKEntityParser<Video> {
        private static readonly Lazy<VideoParser> Lazy = new Lazy<VideoParser>( () => new VideoParser() );
        public static VideoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private VideoParser() {}

        public Video ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Video[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
