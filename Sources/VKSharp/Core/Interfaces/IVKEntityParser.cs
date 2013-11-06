using System.Collections.Generic;
using System.Xml.Linq;

namespace VKSharp.Core.Interfaces {
    public interface IVKEntityParser<out T> {
        T ParseFromXml(XNode node);
        T[] ParseAllFromXml(IEnumerable<XNode> nodes);
    }
}