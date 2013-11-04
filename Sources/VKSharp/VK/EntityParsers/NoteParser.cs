using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class NoteParser:IVKEntityParser<Note> {
        private static readonly Lazy<NoteParser> Lazy = new Lazy<NoteParser>( () => new NoteParser() );
        public static NoteParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private NoteParser() { }

        public Note ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Note[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
