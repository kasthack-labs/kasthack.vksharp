using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class UniversityParser : IVKEntityParser<University> {
        private static readonly Lazy<UniversityParser> Lazy = new Lazy<UniversityParser>( () => new UniversityParser() );
        public static UniversityParser Instanse {
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
