using System;

namespace kasthack.vksharp.Internal.Converters
{
    internal static class ConverterHelpers
    {

        private static readonly Type NullableType = typeof(Nullable<>);

        public static bool IsNullable(this Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == NullableType;
    }
}
