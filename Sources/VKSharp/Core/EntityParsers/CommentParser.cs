using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
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
