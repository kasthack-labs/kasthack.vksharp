using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class CommentLikesParser : IVKEntityParser<CommentLikes> {
        private static readonly Lazy<CommentLikesParser> Lazy = new Lazy<CommentLikesParser>( () => new CommentLikesParser() );
        public static CommentLikesParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private CommentLikesParser() { }
        public CommentLikes ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public CommentLikes[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public CommentLikes ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref CommentLikes entity) {
            throw new NotImplementedException();
        }

    }
}
