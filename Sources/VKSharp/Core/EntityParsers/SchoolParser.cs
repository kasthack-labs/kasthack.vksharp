using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class SchoolParser : IVKEntityParser<School> {
        private static readonly Lazy<SchoolParser> Lazy = new Lazy<SchoolParser>( () => new SchoolParser() );
        public static SchoolParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private SchoolParser() { }

        public School ParseFromXml( XmlNode node ) {
            var sc = new School();
            foreach ( XmlNode cn in node.ChildNodes ) {
                switch ( cn.Name ) {
                    case "city":
                        sc.City = uint.Parse( cn.InnerText );
                        break;
                    case "country":
                        sc.Country = uint.Parse( cn.InnerText );
                        break;
                    case "id":
                        sc.ID = uint.Parse( cn.InnerText );
                        break;
                    case "type":
                        sc.Type = uint.Parse( cn.InnerText );
                        break;
                    case "type_name":
                        sc.TypeName = uint.Parse( cn.InnerText );
                        break;
                    case "graduation":
                        sc.Graduation = ushort.Parse( cn.InnerText );
                        break;
                    case "year_from":
                        sc.YearFrom = ushort.Parse( cn.InnerText );
                        break;
                    case "year_to":
                        sc.YearTo = ushort.Parse( cn.InnerText );
                        break;
                    case "class":
                        sc.Class = cn.InnerText;
                        break;
                    case "name":
                        sc.Name = cn.InnerText;
                        break;
                    case "speciality":
                        sc.Speciality = cn.InnerText;
                        break;
                }
            }
            return sc;
        }

        public School[] ParseAllFromXml( IEnumerable<XmlNode> nodes ) {
            return nodes.Select( this.ParseFromXml ).ToArray();
        }
    }
}
