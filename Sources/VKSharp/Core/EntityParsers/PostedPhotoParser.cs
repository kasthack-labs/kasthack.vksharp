using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostedPhotoParser:IVKEntityParser<PostedPhoto> {
        private static readonly Lazy<PostedPhotoParser> Lazy = new Lazy<PostedPhotoParser>( () => new PostedPhotoParser() );
        public static PostedPhotoParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private PostedPhotoParser() { }
        
        public PostedPhoto ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public PostedPhoto[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public PostedPhoto ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref PostedPhoto entity) {
            throw new NotImplementedException();
        }

    }
}