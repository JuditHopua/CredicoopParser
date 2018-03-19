using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;

namespace Eternet.Bancos.Parser.Maps
{
    public sealed class FrancesRecordMap : ClassMap<FrancesRecord>
    {
        private const int DateIndex = 0;
        private const int ValueDateIndex = 1;
        private const int ConceptIndex = 2;
        private const int CodeIndex = 3;
        private const int DocumentNumberIndex = 4;
        private const int OfficeIndex = 5;
        private const int CreditIndex = 6;
        private const int DebitIndex = 7;
        private const int DetailIndex = 8;

        public FrancesRecordMap()
        {
            Map(m => m.Date)
                .Index(DateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(DateIndex);
                        return str.ToFrancesDateTime();
                    });
            Map(m => m.ValueDate)
                .Index(ValueDateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(DateIndex);
                        return str.ToFrancesDateTime();
                    });
            Map(m => m.Concept).Index(ConceptIndex);

            Map(m => m.Code).Index(CodeIndex);

            Map(m => m.DocumentNumber).Index(DocumentNumberIndex);

            Map(m => m.Office).Index(OfficeIndex);

            Map(m => m.Credit).Index(CreditIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(CreditIndex);
                    return str.ToDecimal();
                });

            Map(m => m.Debit).Index(DebitIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(DebitIndex);
                    return str.ToDecimal();
                });

            Map(m => m.Detail).Index(DetailIndex);
        }
    }
}
