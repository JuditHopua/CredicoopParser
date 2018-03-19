using System;

namespace Eternet.Bancos.Parser.Extensions
{
    public static class DecimalExtensionMethods
    {
        public static decimal ToDecimal(this string str)
        {
            if (!decimal.TryParse(str, out var result))
                throw new ArgumentException($"Can't convert {str} to a decimal");
            return result;
        }
    }
}
