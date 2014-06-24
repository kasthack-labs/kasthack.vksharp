using System.Collections.Generic;
using System.Xml.Linq;

namespace VKSharp.Core.Interfaces {
    public interface IXmlVKEntityParser<T> : IXmlVKEntityParser where T : IVKEntity<T>{
        //
        void FillFromXml( IEnumerable<XElement> nodes, T entity );
        //parse one from xml node
        T ParseFromXml( XElement node );
        //same for array
        T[] ParseAllFromXml( IEnumerable<XElement> nodes );
        //parse from set of nodёs
        T ParseFromXmlFragments( IEnumerable<XElement> nodes );
        //update
        bool UpdateFromFragment( XElement node, T entity );
        //bad name but I have no better idea
        //used to add parsers for subentities
        void Attach();
    }
}