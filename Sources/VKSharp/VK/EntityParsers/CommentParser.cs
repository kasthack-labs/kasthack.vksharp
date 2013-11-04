using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class CommentParser:IVKEntityParser<Comment> {
        private static readonly Lazy<CommentParser> Lazy = new Lazy<CommentParser>( () => new CommentParser() );
        public static CommentParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private CommentParser() { }
        public Comment ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Comment[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
