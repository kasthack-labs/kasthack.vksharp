using System.Linq;
using VKSharp.Core.Entities;

namespace VKSharp.Core.EntityParsers.Xml {
    public class UniversityParser : DefaultParser<University> {
        private static object _userParserLocker = false;
        public UniversityParser() {
            lock (_userParserLocker) {
                if((bool)_userParserLocker) return;
                var v = GeneratedParsers;
                foreach ( var action in v.Keys.Where( a => !( a == "id" || a == "name") ).ToArray() )
                    v.Remove( action );
                _userParserLocker = true;
            }
        }
    }
}
