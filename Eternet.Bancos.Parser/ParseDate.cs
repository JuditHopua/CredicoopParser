using Eternet.Bancos.Parser.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eternet.Bancos.Parser
{
    public class ParseDate
    {
        private static readonly Dictionary<string, int> MonthDictionary = new Dictionary<string, int>
        {
            { "ene", 1 },
            { "feb", 2 },
            { "mar", 3 },
            { "abr", 4 },
            { "may", 5 },
            { "jun", 6 },
            { "jul", 7 },
            { "ago", 8 },
            { "set", 9 },
            { "oct", 10 },
            { "nov", 11 },
            { "dic", 12 }
        };

        private readonly string _str;

        public ParseDate(string str)
        {
            _str = str;
        }
        public DateTime GetDateBancoProvincia()
        {
            var splits = _str.Split(_str.BestSeparator());
            var strmonth = splits.Skip(1).FirstOrDefault().ToLower();
            var day = Convert.ToInt32(splits.FirstOrDefault());
            var month = MonthDictionary[strmonth];
            var year = Convert.ToInt32(splits.LastOrDefault());
            return new DateTime(year, month, day);

        }

    }
}
