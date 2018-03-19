using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;

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
                        return str.ToProvinciaDateTime();
                    });
            Map(m => m.Concept).Index(ConceptIndex);

            Map(m => m.Amount).Index(AmountIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(AmountIndex);
                    return str.ToDecimal();
                });

            Map(m => m.Balance).Index(BalanceIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(BalanceIndex);
                    return str.ToDecimal();
                });
        }

    }
}
