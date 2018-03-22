using System;

namespace Eternet.Bancos.Parser.Extensions
{
    public static class DecimalExtensionMethods
    {
        public static decimal ToDecimal(this string str)
        {
            str = str.Replace("(", "-").Replace(")", "").Trim();
            if (!decimal.TryParse(str, out var result))
            {
                if (str == "")
                {
                    return 0.00m;
                }
                else
                {
                    throw new ArgumentException($"Can't convert {str} to a decimal");
                }
            }
            return result;
        }
    }
}
