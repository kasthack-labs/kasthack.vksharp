using System.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UniversityParser : DefaultParser<University> {
        private static object _userParserLocker = false;
        public UniversityParser() {
            lock (_userParserLocker) {
                if((bool)_userParserLocker) return;
                var v = GeneratedParsers;
                _userParserLocker = true;
            }
        }
    }
}
