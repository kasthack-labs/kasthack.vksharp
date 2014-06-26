using System;
using System.Collections.Generic;
using System.Linq;
using VKSharp.Data.Parameters;

namespace VKSharp.Helpers {
    public static class MiscTools {
        public static string[] GetUserFields(UserFields fields) {
            var s = Enum.GetValues( typeof( UserFields ) )
                .OfType<UserFields>()
                .Where(a => a != UserFields.Everything&& a!=UserFields.None)
                .Where(a => (fields & a)==a)
                .Select(a => a.ToNClString().ToSnake())
                .ToArray();
            return s;
        }
        public static string[] GetFilterFields( FriendSuggestionFilters fields ) {
            var s = Enum.GetValues( typeof( FriendSuggestionFilters ) )
                .OfType<FriendSuggestionFilters>()
                .Where( a => a != FriendSuggestionFilters.Everything )
                .Where( a => fields.HasFlag( a ) )
                .Select( a => a.ToNClString().ToSnake() )
                .ToArray();
            return s;
        }

        public static string NullableString<T>(T? input) where T : struct,IFormattable {
            return input.HasValue ? input.Value.ToNCString() : "";
        }

        public static string ToNCString<T>(this T value) where T: IFormattable {
            return ((IFormattable)value).ToString( null, BuiltInData.Instance.NC);
        }
        public static string ToNClString<T>( this T value ) where T : IFormattable {
            return ( (IFormattable) value )
                .ToString( null, BuiltInData.Instance.NC )
                .ToLower( BuiltInData.Instance.NC );
        }

        public static string ToNCStringA<T>( this IEnumerable<T> value ) where T : IFormattable {
            return String.Join( ",", value.Select( a => a.ToNCString() ) );
        }
    }
}
