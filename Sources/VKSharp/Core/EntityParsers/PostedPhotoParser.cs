using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostedPhotoParser:IVKEntityParser<PostedPhoto> {
        private static readonly Lazy<PostedPhotoParser> Lazy = new Lazy<PostedPhotoParser>( () => new PostedPhotoParser() );
        public static PostedPhotoParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private PostedPhotoParser() { }
        
        public PostedPhoto ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public PostedPhoto[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}