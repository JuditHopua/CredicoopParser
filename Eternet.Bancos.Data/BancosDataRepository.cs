using Eternet.Bancos.Data.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Eternet.Bancos.Data
{
    public class BancosDataRepository : IBancosDataRepository
    {
        private const string CollectionName = "BankMovements";
        private readonly IMongoCollection<BankDocument> _collection;

        public BancosDataRepository(IMongoDatabase mongodb)
        {
            _collection = mongodb.GetCollection<BankDocument>(CollectionName);
        }
        public void Add(BankDocument document)
        {
            throw new NotImplementedException();
        }

        public bool Replace(BankDocument document)
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(object id)
        {
            throw new NotImplementedException();
        }

        public BankDocument GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankDocument> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
