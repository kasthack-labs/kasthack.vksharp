using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UniversityParser : IXmlVKEntityParser<University> {
        public IExecutor Executor { get; set; }
        
        public void FillFromXml(IEnumerable<XmlNode> nodes, University entity) {
            foreach ( var cn in nodes )
                this.UpdateFromFragment( cn, entity );
        }

        public University ParseFromXml(XmlNode node) {
            return String.CompareOrdinal(node.Name, "university") != 0 ? null : this.ParseFromXmlFragments(node.ChildNodes.OfType<XmlNode>());
        }

        public University[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).Where(a=>a!=null).ToArray();
        }

        public University ParseFromXmlFragments(IEnumerable<XmlNode> nodes) {
            var sc = new University();
            this.FillFromXml(nodes, sc);
            return sc;
        }

        public void UpdateFromFragment(XmlNode node, University entity) {
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
                case "name":
                    entity.Name = node.InnerText;
                    break;
                case "chair":
                    entity.Chair = uint.Parse( node.InnerText );
                    break;
                case "faculty":
                    entity.Faculty = uint.Parse( node.InnerText );
                    break;
                case "chair_name":
                    entity.ChairName = node.InnerText;
                    break;
                case "faculty_name":
                    entity.FacultyName = node.InnerText;
                    break;
                case "graduation":
                    entity.Graduation = ushort.Parse( node.InnerText );
                    break;
                case "education_form":
                    entity.EducationForm = node.InnerText;
                    break;
                case "education_status":
                    entity.EducationStatus = node.InnerText;
                    break;
            }
        }
    }
}
