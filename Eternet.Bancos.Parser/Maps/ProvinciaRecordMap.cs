using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;
using System;

namespace Eternet.Bancos.Parser.Maps
{
    public sealed class ProvinciaRecordMap : ClassMap<ProvinciaRecord>
    {
        private const int DateIndex = 0;
        private const int ConceptIndex = 1;
        private const int AmountIndex = 2;
        private const int BalanceIndex = 3;

        public ProvinciaRecordMap()
        {
            Map(m => m.Date)
                .Index(DateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(DateIndex);
                        return str.ToProcinciaDateTime();
                    });
            Map(m => m.Concept).Index(ConceptIndex);

            Map(m => m.Amount).Index(AmountIndex)
                .ConvertUsing(row => ToDecimal(row, AmountIndex));

            Map(m => m.Balance).Index(BalanceIndex)
                .ConvertUsing(row => ToDecimal(row, BalanceIndex));
        }

        private static decimal ToDecimal(CsvHelper.IReaderRow row, int index)
        {
            var str = row.GetField<string>(index);
            if (!decimal.TryParse(str, out var result))
                throw new ArgumentException($"Can't convert {str} to a decimal");
            return result;
        }
    }
}
