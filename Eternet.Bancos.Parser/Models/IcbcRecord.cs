using System;

namespace Eternet.Bancos.Parser.Models
{
    public class IcbcRecord
    {
        public DateTime Date { get; set; }
        public string ConceptCode { get; set; }
        public string Concept { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public string ComplementaryInfo { get; set; }
        public string CheckNumber { get; set; }
        public int FromOffice { get; set; }
        public string Channel { get; set; }
    }
}
