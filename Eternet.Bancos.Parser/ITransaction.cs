using Eternet.Bancos.Parser.Models;
using System.Collections.Generic;

namespace Eternet.Bancos.Parser
{
    interface ITransaction
    {
        //IEnumerable<CredicoopRecord> ReadTransactions(bool hasHeaders = true);

        IEnumerable<ProvinciaRecord> ReadTransactions(bool hasHeaders = true);

    }
}
