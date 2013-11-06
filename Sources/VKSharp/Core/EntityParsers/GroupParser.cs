using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class GroupParser : IVKEntityParser<Group> {
        private static readonly Lazy<GroupParser> Lazy = new Lazy<GroupParser>( () => new GroupParser() );
        public static GroupParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private GroupParser() {}

        public Group ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Group[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
