using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class UserParser:IVKEntityParser<User> {
        private static readonly Lazy<UserParser> Lazy = new Lazy<UserParser>( () => new UserParser() );
        public static UserParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        public User ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public User[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
