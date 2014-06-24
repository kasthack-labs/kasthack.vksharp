using VKSharp.Data.Executors;

namespace VKSharp.Core.Interfaces {
    public interface IXmlVKEntityParser {
        IExecutor Executor { get; set; }
    }
}
