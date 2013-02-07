using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static int LengthOrDefault(this string texto)
        {
            if (texto == null)
                return 0;

            return texto.Length;
        }
    }
}
