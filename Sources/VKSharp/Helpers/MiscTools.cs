using System;
using System.Linq;
using VKSharp.Data.Parameters;

namespace VKSharp.Helpers {
    static class MiscTools {
        public static string[] GetUserFields(UserFields fields) {
            return Enum.GetValues(typeof (UserFields))
                .OfType<UserFields>()
                .Where(a => a != UserFields.Everything)
                .Where(a => fields.HasFlag(a))
                .Select(a => a.ToNCLString())
                .ToArray();
        }
        public static string[] GetFilterFields( FriendSuggestionFilters fields ) {
            return Enum.GetValues( typeof( FriendSuggestionFilters ) )
                .OfType<FriendSuggestionFilters>()
                .Where( a => a != FriendSuggestionFilters.Everything )
                .Where( a => fields.HasFlag( a ) )
                .Select( a => a.ToNCLString() )
                .ToArray();
        }

        public static string NullableString<T>(T? input) where T : struct,IFormattable {
            return input.HasValue ? input.Value.ToNCString() : "";
        }

        public static string ToNCString<T>(this T value) where T: IFormattable {
            return ((IFormattable)value).ToString( "{0}", BuiltInData.Instance.NC);
        }
        public static string ToNCLString<T>( this T value ) where T : IFormattable {
            return ( (IFormattable) value ).ToString( "{0}", BuiltInData.Instance.NC ).ToLower( BuiltInData.Instance.NC );
        }
    }
}
