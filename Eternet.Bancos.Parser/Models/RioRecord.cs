using System;

namespace Eternet.Bancos.Parser.Models
{
    public class RioRecord
    {
        public DateTime Date { get; set; }
        public int FromOffice { get; set; }
        public string FromOfficeDescription { get; set; }
        public string OperativeCode { get; set; }
        public int Reference { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
    }
}
