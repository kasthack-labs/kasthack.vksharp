using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VKSharp.Data.Parameters;

namespace VKSharp.Helpers {
    public static class MiscTools {
        /// <summary>
        /// Converts CamelCase targetInnerType snake_case
        /// </summary>
        /// <param name="name">Name for converting</param>
        /// <returns>Converted string</returns>
        public static string ToSnake( this string name ) {
            var t = new StringBuilder();
            t.Append( Char.ToLower( name[ 0 ] ) );
            for ( var index = 1; index < name.Length; index++ ) {
                var c = name[ index ];
                //add '_' before numbers and captials 
                if ( Char.IsUpper( c )
                     || ( Char.IsNumber( c ) && !Char.IsNumber( name[ index - 1 ] ) ) ) {
                    t.Append( '_' );
                    t.Append( Char.ToLower( c ) );
                }
                else t.Append( c );
            }
            return t.ToString();
        }

        public static string ToMeth( this string name, bool p = false ) {
            var t = new StringBuilder();
            t.Append( p ? Char.ToLower( name[ 0 ] ) : Char.ToUpper( name[ 0 ] ) );
            for ( var index = 1; index < name.Length; index++ ) {
                var c = name[ index ];
                //add '_' before numbers and capitals 
                if ( c == '.' || c == '_' ) t.Append( Char.ToUpper( name[ ++index ] ) );
                else t.Append( c );
            }
            return t.ToString();
        }

        public static string[] GetGroupFields( GroupFields fields ) {
            var s =
                Enum.GetValues( typeof( GroupFields ) )
                    .OfType<GroupFields>()
                    .Where( a => a != GroupFields.Everything && a != GroupFields.None )
                    .Where( a => ( fields & a ) == a )
                    .Select( a => a.ToNCString().ToSnake() )
                    .ToArray();
            return s;
        }

        public static string[] GetUserFields( UserFields fields ) {
            var s =
                Enum.GetValues( typeof( UserFields ) )
                    .OfType<UserFields>()
                    .Where( a => a != UserFields.Everything && a != UserFields.None )
                    .Where( a => ( fields & a ) == a )
                    .Select( a => a.ToNCString().ToSnake() )
                    .ToArray();
            return s;
        }

        //public static string[] GetEnumFlags<TEnum>( TEnum value, TEnum everything, TEnum none ) where TEnum: Enum
        //{
            
        //}

        public static string[] GetFilterFields( FriendSuggestionFilters fields ) {
            var s =
                Enum.GetValues( typeof( FriendSuggestionFilters ) )
                    .OfType<FriendSuggestionFilters>()
                    .Where( a => a != FriendSuggestionFilters.Everything )
                    .Where( a => ( fields & a ) == a )
                    .Select( a => a.ToNClString().ToSnake() )
                    .ToArray();
            return s;
        }

        public static string NullableString<T>( T? input ) where T : struct, IFormattable {
            return input.HasValue ? input.Value.ToNCString() : "";
        }

        public static string ToNCString<T>( this T value ) where T : IFormattable {
            return ( (IFormattable) value ).ToString( null, BuiltInData.Instance.NC );
        }

        public static string ToNClString<T>( this T value ) where T : IFormattable {
            return ( (IFormattable) value ).ToString( null, BuiltInData.Instance.NC ).ToLower( BuiltInData.Instance.NC );
        }

        public static string ToNCStringA<T>( this IEnumerable<T> value ) where T : IFormattable {
            return String.Join( ",", value.Select( a => a.ToNCString() ) );
        }
    }
}