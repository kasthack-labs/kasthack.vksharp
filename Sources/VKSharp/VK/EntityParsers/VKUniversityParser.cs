using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    class VKUniversityParser : IVKEntityParser<University> {
        private static readonly Lazy<VKUniversityParser> Lazy = new Lazy<VKUniversityParser>( () => new VKUniversityParser() );
        public static VKUniversityParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        public University ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public University[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
