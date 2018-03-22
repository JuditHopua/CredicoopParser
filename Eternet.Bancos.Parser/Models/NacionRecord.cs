using System;

namespace Eternet.Bancos.Parser.Models
{
    public class NacionRecord
    {
        public DateTime MovDate { get; set; }
        public DateTime ValueDate { get; set; }
        public decimal Amount { get; set; }
        public string Reference { get; set; }
        public string Concept { get; set; }
        public decimal Balance { get; set; }
    }
}

