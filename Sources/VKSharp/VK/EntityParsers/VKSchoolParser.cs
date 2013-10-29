using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    class VKSchoolParser : IVKEntityParser<School> {
        private static readonly Lazy<VKSchoolParser> Lazy = new Lazy<VKSchoolParser>( () => new VKSchoolParser() );
        public static VKSchoolParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        public School ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public School[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
