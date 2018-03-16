using System;

namespace Eternet.Bancos.Parser.Models
{
    public class ProvinciaRecord
    {
        public DateTime Date { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
    }
}
