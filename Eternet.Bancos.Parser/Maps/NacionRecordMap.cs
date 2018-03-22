using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;

namespace Eternet.Bancos.Parser.Maps
{
    public sealed class NacionRecordMap : ClassMap<NacionRecord>
    {
        private const int MovDateIndex = 0;
        private const int ValueDateIndex = 1;
        private const int AmountIndex = 2;
        private const int ReferenceIndex = 3;
        private const int ConceptIndex = 4;
        private const int BalanceIndex = 5;

        public NacionRecordMap()
        {
            Map(m => m.MovDate)
                .Index(MovDateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(MovDateIndex);
                        return str.ToSlashDateTime();
                    });
            Map(m => m.ValueDate)
                .Index(ValueDateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(ValueDateIndex);
                        return str.ToSlashDateTime();
                    });
            Map(m => m.Amount).Index(AmountIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(AmountIndex);
                    return str.ToDecimal();
                });
            Map(m => m.Reference).Index(ReferenceIndex);
            Map(m => m.Concept).Index(ConceptIndex);
            Map(m => m.Balance).Index(BalanceIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(BalanceIndex);
                    return str.ToDecimal();
                });
        }
    }
}