using System.Collections.Generic;
using System.Xml;

namespace VKSharp.Core.Interfaces {
    public interface IVKEntityParser<T> {
        //parse one from xml node
        T ParseFromXml(XmlNode node);
        //same for array
        T[] ParseAllFromXml( IEnumerable<XmlNode> nodes );
        //parse from set of nodes
        T ParseFromXmlFragments(IEnumerable<XmlNode> nodes);
        //update
        void UpdateFromFragment(XmlNode node, ref T entity);
        //parse_ref

    }
}