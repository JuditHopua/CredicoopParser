using CsvHelper;
using Eternet.Bancos.Parser.Maps;
using Eternet.Bancos.Parser.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Eternet.Bancos.Parser
{
    public class Transaction : ITransaction
    {
        private readonly string _file;

        private const string auxiliarFile =
            @"C:\Users\judit\source\repos\CredicoopParser\IntegrationTest\assets\fileFromHeaders.csv";

        public Transaction(string file)
        {
            _file = file;
        }

        public IEnumerable<ProvinciaRecord> ReadTransactionsProvincia()
        {
            var delimiter = new ParserDelimiter(File.ReadAllLines(_file).FirstOrDefault());
            var separator = delimiter.GetBestCharDelimiter();
            var csv = new CsvReader(File.OpenText(_file));
            csv.Configuration.Delimiter = $"{separator}";
            csv.Configuration.HasHeaderRecord = true;
            csv.Configuration.HeaderValidated = null;
            csv.Configuration.RegisterClassMap<ProvinciaRecordMap>();
            var results = csv.GetRecords<ProvinciaRecord>().ToArray();
            return results;
        }

        public IEnumerable<CredicoopRecord> ReadTransactionsCredicoop()
        {
            var delimiter = new ParserDelimiter(File.ReadAllLines(_file).FirstOrDefault());
            var separator = delimiter.GetBestCharDelimiter();
            var csv = new CsvReader(File.OpenText(_file));
            csv.Configuration.Delimiter = $"{separator}";
            csv.Configuration.HasHeaderRecord = true;
            csv.Configuration.HeaderValidated = null;
            csv.Configuration.RegisterClassMap<CredicoopRecordMap>();
            var results = csv.GetRecords<CredicoopRecord>().ToArray();
            return results;

        }

        public IEnumerable<FrancesRecord> ReadTransactionsFrances()
        {
            var delimiter = new ParserDelimiter(File.ReadLines(_file).FirstOrDefault());
            var separator = delimiter.GetBestCharDelimiter();

            List<string> linesFile = File.ReadAllLines(_file).ToList();
            linesFile.RemoveRange(0, 6);
            File.WriteAllLines(auxiliarFile, linesFile.ToArray());

            var csv = new CsvReader(File.OpenText(auxiliarFile));
            csv.Configuration.Delimiter = $"{separator}";
            csv.Configuration.HasHeaderRecord = true;
            csv.Configuration.HeaderValidated = null;
            csv.Configuration.RegisterClassMap<FrancesRecordMap>();
            var results = csv.GetRecords<FrancesRecord>().ToArray();
            return results;
        }
    }
}
