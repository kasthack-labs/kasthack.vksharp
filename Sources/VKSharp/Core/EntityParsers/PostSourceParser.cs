using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostSourceParser : IVKEntityParser<PostSource> {
        private static readonly Lazy<PostSourceParser> Lazy = new Lazy<PostSourceParser>( () => new PostSourceParser() );
        public static PostSourceParser Instanse {
            get {
                return Lazy.Value;
            }
        }
        private PostSourceParser() { }
        
        public PostSource ParseFromXml( XNode node ) {
            throw new NotImplementedException();
        }

        public PostSource[] ParseAllFromXml( IEnumerable<XNode> nodes ) {
            throw new NotImplementedException();
        }
    }
}
