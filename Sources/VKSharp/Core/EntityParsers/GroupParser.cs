﻿using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class GroupParser : IVKEntityParser<Group> {
        private static readonly Lazy<GroupParser> Lazy = new Lazy<GroupParser>( () => new GroupParser() );
        public static GroupParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private GroupParser() {}

        public void FillFromXml(IEnumerable<XmlNode> nodes, ref Group entity) {
            throw new NotImplementedException();
        }

        public Group ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Group[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public Group ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }

        public void UpdateFromFragment(XmlNode node, ref Group entity) {
            throw new NotImplementedException();
        }
    }
}