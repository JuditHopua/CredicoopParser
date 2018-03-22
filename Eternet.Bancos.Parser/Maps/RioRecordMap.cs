using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;

namespace Eternet.Bancos.Parser.Maps
{
    public sealed class RioRecordMap : ClassMap<RioRecord>
    {
        private const int DateIndex = 0;
        private const int FromOfficeIndex = 1;
        private const int FromOfficeDescriptionIndex = 2;
        private const int OperativeCodeIndex = 3;
        private const int ReferenceIndex = 4;
        private const int ConceptIndex = 5;
        private const int AmountIndex = 6;
        private const int BalanceIndex = 7;

        public RioRecordMap()
        {
            Map(m => m.Date)
                .Index(DateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(DateIndex);
                        return str.ToSlashDateTime();
                    });

            Map(m => m.FromOffice).Index(FromOfficeIndex);

            Map(m => m.FromOfficeDescription).Index(FromOfficeDescriptionIndex);

            Map(m => m.OperativeCode).Index(OperativeCodeIndex);

            Map(m => m.Reference).Index(ReferenceIndex);

            Map(m => m.Concept).Index(ConceptIndex);

            Map(m => m.Amount).Index(AmountIndex)
                .ConvertUsing(row =>
                    {
                        var str = row.GetField<string>(AmountIndex);
                        return str.ToDecimal();
                    }
                );

            Map(m => m.Balance).Index(BalanceIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(BalanceIndex);
                    return str.ToDecimal();
                });
        }

    }
}
