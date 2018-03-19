using System;

namespace Eternet.Bancos.Parser.Models
{
    public class FrancesRecord
    {
        public DateTime Date { get; set; }
        public DateTime ValueDate { get; set; }
        public string Concept { get; set; }
        public int Code { get; set; }
        public string DocumentNumber { get; set; }
        public string Office { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public string Detail { get; set; }
    }
}
