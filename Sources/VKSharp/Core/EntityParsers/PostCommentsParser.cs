using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostCommentsParser:IVKEntityParser<PostComments> {
        private static readonly Lazy<PostCommentsParser> Lazy = new Lazy<PostCommentsParser>( () => new PostCommentsParser() );
        public static PostCommentsParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostCommentsParser() { }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostComments entity) {
            throw new NotImplementedException();
        }

        public PostComments ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostComments[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostComments ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostComments entity) {
            throw new NotImplementedException();
        }

    }
}
