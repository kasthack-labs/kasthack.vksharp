using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class CommentLikesParser : IVKEntityParser<CommentLikes> {
        private static readonly Lazy<CommentLikesParser> Lazy = new Lazy<CommentLikesParser>( () => new CommentLikesParser() );
        public static CommentLikesParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private CommentLikesParser() { }
        public CommentLikes ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public CommentLikes[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
