using System;

namespace Eternet.Bancos.Parser.Models
{
    public class CredicoopRecord
    {
        public DateTime Date { get; set; }
        public string Concept { get; set; }
        public string VoucherNumber { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public string Code { get; set; }
    }
}
