using System.Collections.Generic;
using System.Xml;
using VKSharp.Data.Executors;

namespace VKSharp.Core.Interfaces {
    public interface IXmlVKEntityParser<T> : IXmlVKEntityParser where T : IVKEntity<T> {
        //
        void FillFromXml( IEnumerable<XmlNode> nodes, T entity );
        //parse one from xml node
        T ParseFromXml(XmlNode node);
        //same for array
        T[] ParseAllFromXml( IEnumerable<XmlNode> nodes );
        //parse from set of nodesё
        T ParseFromXmlFragments(IEnumerable<XmlNode> nodes);
        //update
        bool UpdateFromFragment(XmlNode node, T entity);
    }
}