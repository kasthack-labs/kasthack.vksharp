using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    class PostParser:IVKEntityParser<Post> {
        private static readonly Lazy<PostParser> Lazy = new Lazy<PostParser>( () => new PostParser() );
        public static PostParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostParser() {}

        public Post ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Post[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Post ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Post entity) {
            throw new NotImplementedException();
        }
    }
}
