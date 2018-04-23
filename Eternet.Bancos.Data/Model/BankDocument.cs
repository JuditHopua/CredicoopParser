using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Eternet.Bancos.Data.Model
{
    public class BankDocument
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("bankName")] public string BankName { get; set; }
        [BsonElement("bankAccount")] public string BankAccount { get; set; }
        [BsonElement("movement")] public List<MovementRecord> MovementRecords { get; set; }
        [BsonElement("processed")] public bool Processed { get; set; }
    }
}
