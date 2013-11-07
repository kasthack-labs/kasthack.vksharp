using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class UniversityParser : IVKEntityParser<University> {
        private static readonly Lazy<UniversityParser> Lazy = new Lazy<UniversityParser>( () => new UniversityParser() );
        public static UniversityParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private UniversityParser() {}

        public University ParseFromXml(XmlNode node) {
            var sc = new University();
            foreach (XmlNode cn in node.ChildNodes) {
                switch ( cn.Name ) {
                    case "city":
                        sc.City = uint.Parse(cn.InnerText);
                        break;
                    case "country":
                        sc.Country = uint.Parse(cn.InnerText);
                        break;
                    case "id":
                        sc.ID = uint.Parse(cn.InnerText);
                        break;
                    case "name":
                        sc.Name = cn.InnerText;
                        break;
                    case "chair":
                        sc.Chair = uint.Parse(cn.InnerText);
                        break;
                    case "faculty":
                        sc.Faculty = uint.Parse( cn.InnerText );
                        break;
                    case "chair_name":
                        sc.ChairName = cn.InnerText;
                        break;
                    case "faculty_name":
                        sc.FacultyName = cn.InnerText;
                        break;
                    case "graduation":
                        sc.Graduation = ushort.Parse(cn.InnerText);
                        break;
                    case "education_form":
                        sc.EducationForm = cn.InnerText;
                        break;
                    case "education_status":
                        sc.EducationStatus = cn.InnerText;
                        break;
                }
            }
            return sc;
        }

        public University[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
    }
}
