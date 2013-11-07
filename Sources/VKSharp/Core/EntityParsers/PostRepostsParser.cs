using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostRepostsParser:IVKEntityParser<PostReposts> {
        private static readonly Lazy<PostRepostsParser> Lazy = new Lazy<PostRepostsParser>( () => new PostRepostsParser() );
        public static PostRepostsParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostRepostsParser() { }
        public PostReposts ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostReposts[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
