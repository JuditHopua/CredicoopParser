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
        private const string CsvFrances = @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\Frances.csv";
        private const string CsvRio = @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\Rio.csv";
        private const string CsvIcbc = @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\ICBC.csv";
        private const string CsvNacion = @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\Nacion.csv";

        [TestMethod]
        public void CheckHeaderCredicoop()
        {
            var parserdelimiter = new ParserDelimiter(File.ReadAllLines(CsvCredicoop).FirstOrDefault());
            var chardelimiter = parserdelimiter.GetBestCharDelimiter();
            const char expected = ',';
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

        [TestMethod]
        public void CheckCsvFrances()
        {
            var transaction = new Transaction(CsvFrances);
            var francesRecords = transaction.ReadTransactionsFrances().ToArray();
            var expectedLengthCsvFrances = File.ReadAllLines(CsvFrances).Length - 7;
            Assert.AreEqual(francesRecords.Length, expectedLengthCsvFrances);
        }

        [TestMethod]
        public void CheckCsvRio()
        {
            var transaction = new Transaction(CsvRio);
            var rioRecords = transaction.ReadTransactionsRio().ToArray();
            var expectedLengthCsvRio = File.ReadAllLines(CsvRio).Length - 17;
            Assert.AreEqual(rioRecords.Length, expectedLengthCsvRio);
        }

        [TestMethod]
        public void CheckCsvIcbc()
        {
            var transaction = new Transaction(CsvIcbc);
            var icbcRecords = transaction.ReadTransactionsIcbc().ToArray();
            var expectedLenghtIcbc = File.ReadAllLines(CsvIcbc).Length - 2;
            Assert.AreEqual(icbcRecords.Length, expectedLenghtIcbc);
        }

        [TestMethod]
        public void CheckCsvNacion()
        {
            var transaction = new Transaction(CsvNacion);
            var nacionRecords = transaction.ReadTransactionsNacion().ToArray();
            var expectedLenghtNacion = File.ReadAllLines(CsvNacion).Length - 8;
            Assert.AreEqual(nacionRecords.Length, expectedLenghtNacion);
        }
    }
}
