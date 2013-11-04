using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class SchoolParser : IVKEntityParser<School> {
        private static readonly Lazy<SchoolParser> Lazy = new Lazy<SchoolParser>( () => new SchoolParser() );
        public static SchoolParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private SchoolParser() {}

        public School ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public School[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
