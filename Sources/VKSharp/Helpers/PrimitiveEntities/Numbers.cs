using VKSharp.Core.Interfaces;
using VKSharp.Helpers.Parsers;

namespace VKSharp.Helpers.PrimitiveEntities {
    public class StructEntity<T> : IVKEntity<StructEntity<T>> where T : struct {
        public T? Data { get; set; }

        public IVKEntityParser<StructEntity<T>> GetParser() {
            return PrimitiveParserFactory.GetParser<T>();
        }
    }
}
