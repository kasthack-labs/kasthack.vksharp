using System;
using System.Linq;
using VKSharp.Data.Parameters;

namespace VKSharp.Helpers {
    class MiscTools {
        public static string[] GetUserFields(UserFields fields) {
            return Enum.GetValues(typeof (UserFields))
                .OfType<UserFields>()
                .Where(a => a != UserFields.Everything)
                .Where(a => fields.HasFlag(a))
                .Select(a => a.ToString().ToLowerInvariant())
                .ToArray();
        }
        public static string[] GetFilterFields( FriendSuggestionFilters fields ) {
            return Enum.GetValues( typeof( FriendSuggestionFilters ) )
                .OfType<FriendSuggestionFilters>()
                .Where( a => a != FriendSuggestionFilters.Everything )
                .Where( a => fields.HasFlag( a ) )
                .Select( a => a.ToString().ToLowerInvariant() )
                .ToArray();
        }
    }
}
