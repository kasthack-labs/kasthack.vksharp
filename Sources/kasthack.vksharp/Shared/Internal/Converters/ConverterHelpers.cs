using System;

namespace kasthack.vksharp.Internal.Converters
{
    internal static class ConverterHelpers
    {

        private static readonly Type NullableType = typeof(Nullable<>);

        public static bool IsNullable(this Type t) =>
#if !PORTABLE
            t.IsGenericType
#else
            t.IsConstructedGenericType//todo: check
#endif
             && t.GetGenericTypeDefinition() == NullableType;
    }
}
