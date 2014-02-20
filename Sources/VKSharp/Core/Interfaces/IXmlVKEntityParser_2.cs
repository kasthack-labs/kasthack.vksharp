using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VKSharp.Data.Executors;

namespace VKSharp.Core.Interfaces {
    public interface IXmlVKEntityParser {
        IExecutor Executor { get; set; }
    }
}
