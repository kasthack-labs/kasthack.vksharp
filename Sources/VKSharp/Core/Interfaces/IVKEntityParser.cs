using System.Collections.Generic;
using System.Xml;

namespace VKSharp.Core.Interfaces {
    public interface IXmlVKEntityParser<T> {
        //
        void FillFromXml( IEnumerable<XmlNode> nodes, ref T entity );
        //parse one from xml node
        T ParseFromXml(XmlNode node);
        //same for array
        T[] ParseAllFromXml( IEnumerable<XmlNode> nodes );
        //parse from set of nodes
        T ParseFromXmlFragments(IEnumerable<XmlNode> nodes);
        //update
        void UpdateFromFragment(XmlNode node, ref T entity);
    }
}