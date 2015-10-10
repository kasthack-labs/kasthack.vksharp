using System;

namespace VKSharp.Helpers
{
    internal static class ConverterHelpers
    {

        private static readonly Type NullableType = typeof(Nullable<>);

        public static bool IsNullable(this Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == NullableType;
    }
}
