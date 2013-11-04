﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class GraffityParser:IVKEntityParser<Graffity> {
        private static readonly Lazy<GraffityParser> Lazy = new Lazy<GraffityParser>( () => new GraffityParser() );
        public static GraffityParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private GraffityParser() { }

        public Graffity ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Graffity[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
