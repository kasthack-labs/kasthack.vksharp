using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    class VKUserParser:IVKEntityParser<VKUser> {
        private static readonly Lazy<VKUserParser> Lazy = new Lazy<VKUserParser>( () => new VKUserParser() );
        public static VKUserParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        public VKUser ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public VKUser[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
