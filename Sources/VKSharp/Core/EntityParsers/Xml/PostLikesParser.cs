using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class PostLikesParser : IXmlVKEntityParser<PostLikes> {
        public IExecutor Executor { get; set; }
        private static readonly Lazy<PostLikesParser> Lazy = new Lazy<PostLikesParser>( () => new PostLikesParser() );
        public static PostLikesParser Instanse {
            get { return Lazy.Value; }
        }

        private PostLikesParser() { }

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref PostLikes entity) {
            throw new NotImplementedException();
        }

        public PostLikes ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostLikes[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostLikes ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostLikes entity) {
            throw new NotImplementedException();
        }
    }
}
