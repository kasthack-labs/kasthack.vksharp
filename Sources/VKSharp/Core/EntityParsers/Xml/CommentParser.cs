using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class CommentParser:IXmlVKEntityParser<Comment> {
        private static readonly Lazy<CommentParser> Lazy = new Lazy<CommentParser>( () => new CommentParser() );
        public static CommentParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private CommentParser() { }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Comment entity) {
            throw new NotImplementedException();
        }

        public Comment ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Comment[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Comment ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Comment entity) {
            throw new NotImplementedException();
        }

    }
}
