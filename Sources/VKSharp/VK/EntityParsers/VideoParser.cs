using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class VideoParser : IVKEntityParser<Video> {
        private static readonly Lazy<VideoParser> Lazy = new Lazy<VideoParser>( () => new VideoParser() );
        public static VideoParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private VideoParser() {}

        public Video ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Video[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
