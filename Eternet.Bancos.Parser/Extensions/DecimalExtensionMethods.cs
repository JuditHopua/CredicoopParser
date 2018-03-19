namespace Eternet.Bancos.Parser.Extensions
{
    public static class DecimalExtensionMethods
    {
        public static decimal ToDecimal(this string str)
        {
            if (!decimal.TryParse(str, out var result))
                return 0.00m;
            return result;
        }
    }
}
