using System;

namespace NukeCore.Extensions.Monad.Response
{
    internal static class EnumHelper
    {
        public static T AsEnum<T>(this string value, T def) where T : struct, Enum
            => Enum.TryParse<T>(value, ignoreCase: true, out var res) ? res : def;
    }
}
