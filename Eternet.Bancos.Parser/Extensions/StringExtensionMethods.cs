using System;
using System.Globalization;

namespace Eternet.Bancos.Parser.Extensions
{
    public static class Separator
    {
        public static char BestSeparator(this string str)
        {
            var parserdelimiter = new ParserDelimiter(str);
            return parserdelimiter.GetBestCharDelimiter();
        }

        public static DateTime ToProvinciaDateTime(this string str)
        {
            var parse = new ParseDate(str);
            return parse.GetDateBancoProvincia();
        }

        public static DateTime ToCredicoopDateTime(this string str)
        {
            var separator = BestSeparator(str);
            var format = "dd" + separator + "MM" + separator + "yyyy";
            return DateTime.ParseExact(str, format, CultureInfo.CurrentCulture);
        }
    }
}