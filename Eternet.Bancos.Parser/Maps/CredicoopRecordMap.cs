using CsvHelper.Configuration;
using Eternet.Bancos.Parser.Extensions;
using Eternet.Bancos.Parser.Models;
using System;

namespace Eternet.Bancos.Parser.Maps
{
    public sealed class CredicoopRecordMap : ClassMap<CredicoopRecord>
    {
        private const int DateIndex = 0;
        private const int ConceptIndex = 1;
        private const int VoucherNumberIndex = 2;
        private const int DebitIndex = 3;
        private const int CreditIndex = 4;
        private const int BalanceIndex = 5;
        private const int CodeIndex = 6;

        public CredicoopRecordMap()
        {
            Map(m => m.Date)
                .Index(DateIndex).ConvertUsing(
                    row =>
                    {
                        var str = row.GetField<string>(DateIndex);
                        return str.ToCredicoopDateTime();
                    });
            Map(m => m.Concept).Index(ConceptIndex);

            Map(m => m.VoucherNumber).Index(VoucherNumberIndex);

            Map(m => m.Debit).Index(DebitIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(DebitIndex);
                    return str.ToDecimal();
                }
                );

            Map(m => m.Credit).Index(CreditIndex)
                .ConvertUsing(row =>
                {
                    var str = row.GetField<string>(CreditIndex);
                    return str.ToDecimal();
                });

            Map(m => m.Balance).Index(BalanceIndex)
                .ConvertUsing(row => {
                    var str = row.GetField<string>(BalanceIndex);
                    return str.ToDecimal();
                });

            Map(m => m.Code).Index(CodeIndex);
        }

    }
}