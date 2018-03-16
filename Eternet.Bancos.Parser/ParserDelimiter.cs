using System;
using System.Linq;

namespace Eternet.Bancos.Parser
{
    public class ParserDelimiter
    {
        private readonly string _headers;

        public ParserDelimiter(string headers)
        {
            if (string.IsNullOrEmpty(headers))
                throw new ArgumentException("Invalid headers");
            _headers = headers;
        }

        public char GetBestCharDelimiter()
        {
            var chars = _headers.Where(c => !char.IsLetterOrDigit(c)).Select(c => c).ToArray();
            var charscounts = chars
                .Select(c => (separator: c, count: chars.Count(cc => cc == c)))
                .OrderByDescending(t => t.count);
            return charscounts.FirstOrDefault().separator;
        }
    }
}
