using System;
using System.Collections.Generic;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class NoteParser:IVKEntityParser<Note> {
        private static readonly Lazy<NoteParser> Lazy = new Lazy<NoteParser>( () => new NoteParser() );
        public static NoteParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private NoteParser() { }

        public Note ParseFromXml(XmlNode node) {
            throw new NotImplementedException();
        }

        public Note[] ParseAllFromXml(IEnumerable<XmlNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
