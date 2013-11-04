using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostLikesParser:IVKEntityParser<PostLikes> {
        private static readonly Lazy<PostLikesParser> Lazy = new Lazy<PostLikesParser>( () => new PostLikesParser() );
        public static PostLikesParser Instanse {
            get { return Lazy.Value; }
        }

        private PostLikesParser() { }

        
        public PostLikes ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public PostLikes[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
