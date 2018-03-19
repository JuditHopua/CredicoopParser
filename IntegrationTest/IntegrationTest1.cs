using Eternet.Bancos.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace IntegrationTest
{
    [TestClass]
    public class IntegrationTest1
    {
        private const string Csvpciafile = @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\Pcia.csv";
        private const string CsvCredicoop =
            @"C:\Users\judit\source\repos\CredicoopParser2\IntegrationTest\assets\Credicoop.csv";

        [TestMethod]
        public void CheckHeaderCredicoop()
        {
            const string file = @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\Credicoop.csv";
            var parserdelimiter = new ParserDelimiter(File.ReadAllLines(file).FirstOrDefault());
            var chardelimiter = parserdelimiter.GetBestCharDelimiter();
            const char expected = ',';
            Assert.AreEqual(chardelimiter, expected);
        }

        [TestMethod]
        public void CheckHeaderProvincia()
        {
            var parserdelimiter = new ParserDelimiter(File.ReadAllLines(Csvpciafile).FirstOrDefault());
            var chardelimiter = parserdelimiter.GetBestCharDelimiter();
            const char expected = ';';
            Assert.AreEqual(chardelimiter, expected);
        }

        [TestMethod]
        public void CheckCsvProvincia()
        {
            var tr = new Transaction(Csvpciafile);
            var expectedcount = File.ReadAllLines(Csvpciafile).Length - 1;
            var recs = tr.ReadTransactionsProvincia().ToArray();
            Assert.AreEqual(recs.Length, expectedcount);
        }

        [TestMethod]
        public void CheckCsvCredicoop()
        {
            var transaction = new Transaction(CsvCredicoop);
            var credicoopRecords = transaction.ReadTransactionsCredicoop().ToArray();
            var expectedLengthCsvCredicoop = File.ReadAllLines(CsvCredicoop).Length - 1;
            Assert.AreEqual(credicoopRecords.Length, expectedLengthCsvCredicoop);
        }
    }
}
