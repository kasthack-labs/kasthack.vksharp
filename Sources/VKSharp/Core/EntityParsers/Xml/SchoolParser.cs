using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class SchoolParser : IXmlVKEntityParser<School> {
        public IExecutor Executor { get; set; }

        private SchoolParser() { }

        public void FillFromXml( IEnumerable<XmlNode> nodes, School entity ) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public School ParseFromXml( XmlNode node ) {
            if ( String.CompareOrdinal( node.Name, "school" ) != 0 )
                return null;
            return this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public School[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where( a => a != null ).ToArray();
        }

        public School ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new School();
            this.FillFromXml(nodes, sc);
            return sc;
        }

        public void UpdateFromFragment(XmlNode node, School entity) {
            switch ( node.Name ) {
                case "city":
                    entity.City = uint.Parse( node.InnerText );
                    break;
                case "country":
                    entity.Country = uint.Parse( node.InnerText );
                    break;
                case "id":
                    entity.ID = uint.Parse( node.InnerText );
                    break;
                case "type":
                    entity.Type = uint.Parse( node.InnerText );
                    break;
                case "type_name":
                    //entity.TypeName = uint.Parse( node.InnerText );
                    break;
                case "graduation":
                    //entity.Graduation = ushort.Parse( node.InnerText );
                    break;
                case "year_from":
                    entity.YearFrom = ushort.Parse( node.InnerText );
                    break;
                case "year_to":
                    entity.YearTo = ushort.Parse( node.InnerText );
                    break;
                case "class":
                    entity.Class = node.InnerText;
                    break;
                case "name":
                    entity.Name = node.InnerText;
                    break;
                case "speciality":
                    entity.Speciality = node.InnerText;
                    break;
            }
        }

    }
}
