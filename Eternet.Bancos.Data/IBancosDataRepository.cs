using Eternet.Bancos.Data.Model;
using System;
using System.Collections.Generic;

namespace Eternet.Bancos.Data
{
    public interface IBancosDataRepository
    {
        void Add(BankDocument document);
        bool Replace(BankDocument document);
        bool RemoveById(Object Id);
        BankDocument GetById(Object Id);
        IEnumerable<BankDocument> GetAll();
    }
}
