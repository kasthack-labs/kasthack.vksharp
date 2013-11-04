using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class PostRepostsParser:IVKEntityParser<PostReposts> {
        private static readonly Lazy<PostRepostsParser> Lazy = new Lazy<PostRepostsParser>( () => new PostRepostsParser() );
        public static PostRepostsParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostRepostsParser() { }
        public PostReposts ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public PostReposts[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
