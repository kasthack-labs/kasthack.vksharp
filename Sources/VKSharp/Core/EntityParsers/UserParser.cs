using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class UserParser:IVKEntityParser<User> {
        private static readonly Lazy<UserParser> Lazy = new Lazy<UserParser>( () => new UserParser() );
        public static UserParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private UserParser() {}

        public User ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public User[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
