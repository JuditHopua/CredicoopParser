using System;

namespace Eternet.Bancos.Parser.Extensions
{
    public static class Separator
    {
        public static char BestSeparator(this string str)
        {
            var parserdelimiter = new ParserDelimiter(str);
            return parserdelimiter.GetBestCharDelimiter();
        }

        public static DateTime ToProcinciaDateTime(this string str)
        {
            var parse = new ParseDate(str);
            return parse.GetDateBancoProvincia();
        }
    }
}