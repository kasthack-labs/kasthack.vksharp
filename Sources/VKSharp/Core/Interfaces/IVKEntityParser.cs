using System.Collections.Generic;
using System.Xml;

namespace VKSharp.Core.Interfaces {
    public interface IVKEntityParser<T> {
        T ParseFromXml(XmlNode node);
        T[] ParseAllFromXml( IEnumerable<XmlNode> nodes );
        T ParseFromXmlFragments(IEnumerable<XmlNode> nodes);
        void UpdateFromFragment(XmlNode node, ref T entity);
    }
}