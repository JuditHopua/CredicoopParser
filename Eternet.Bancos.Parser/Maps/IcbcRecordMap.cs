using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;

namespace Eternet.Bancos.Parser.Maps
{
    public sealed class IcbcRecordMap : ClassMap<IcbcRecord>
    {
        private const int DateIndex = 0;
        private const int ConceptCodeIndex = 1;
        private const int ConceptIndex = 2;
        private const int DebitIndex = 3;
        private const int CreditIndex = 4;
        private const int BalanceIndex = 5;
        private const int ComplementaryInfoIndex = 6;
        private const int CheckNumberIndex = 7;
        private const int FromOfficeIndex = 8;
        private const int ChannelIndex = 9;

        public IcbcRecordMap()
        {
            Map(m => m.Date)
                .Index(DateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(DateIndex);
                        return str.ToSlashDateTime();
                    });
            Map(m => m.ConceptCode).Index(ConceptCodeIndex);
            Map(m => m.Concept).Index(ConceptIndex);
            Map(m => m.Debit).Index(DebitIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(DebitIndex);
                    return str.ToDecimal();
                });
            Map(m => m.Credit).Index(CreditIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(DebitIndex);
                    return str.ToDecimal();
                });
            Map(m => m.Balance).Index(BalanceIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(BalanceIndex);
                    return str.ToDecimal();
                });
            Map(m => m.ComplementaryInfo).Index(ComplementaryInfoIndex);
            Map(m => m.CheckNumber).Index(CheckNumberIndex);
            Map(m => m.FromOffice).Index(FromOfficeIndex);
            Map(m => m.Channel).Index(ChannelIndex);
        }

    }
}
