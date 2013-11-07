using System.Collections.Generic;
using System.Xml;

namespace VKSharp.Core.Interfaces {
    public interface IVKEntityParser<out T> {
        T ParseFromXml(XmlNode node);
        T[] ParseAllFromXml( IEnumerable<XmlNode> nodes );
    }
}