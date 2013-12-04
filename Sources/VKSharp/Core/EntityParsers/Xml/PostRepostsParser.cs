using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostRepostsParser:IXmlVKEntityParser<PostReposts> {
        private static readonly Lazy<PostRepostsParser> Lazy = new Lazy<PostRepostsParser>( () => new PostRepostsParser() );
        public static PostRepostsParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostRepostsParser() { }
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostReposts entity) {
            throw new NotImplementedException();
        }

        public PostReposts ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostReposts[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostReposts ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostReposts entity) {
            throw new NotImplementedException();
        }
    }
}
