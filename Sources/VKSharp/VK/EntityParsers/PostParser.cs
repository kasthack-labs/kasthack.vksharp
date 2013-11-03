using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    class PostParser:IVKEntityParser<Post> {
        private static readonly Lazy<PostParser> Lazy = new Lazy<PostParser>( () => new PostParser() );
        public static PostParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostParser() {}

        public Post ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Post[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
