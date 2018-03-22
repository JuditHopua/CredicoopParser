using Eternet.Bancos.Parser.Models;
using System.Collections.Generic;

namespace Eternet.Bancos.Parser
{
    interface ITransaction
    {
        IEnumerable<CredicoopRecord> ReadTransactionsCredicoop();

        IEnumerable<ProvinciaRecord> ReadTransactionsProvincia();

        IEnumerable<FrancesRecord> ReadTransactionsFrances();

        IEnumerable<RioRecord> ReadTransactionsRio();

    }
}
