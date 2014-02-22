using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace VKSharp.Core.Interfaces {
    public interface IXmlVKEntityParser<T> : IXmlVKEntityParser where T : IVKEntity<T> {
        //
        void FillFromXml( IEnumerable<XElement> nodes, T entity );
        //parse one from xml node
        T ParseFromXml( XElement node );
        //same for array
        T[] ParseAllFromXml( IEnumerable<XElement> nodes );
        //parse from set of nodesё
        T ParseFromXmlFragments( IEnumerable<XElement> nodes );
        //update
        bool UpdateFromFragment( XElement node, T entity );
    }
}