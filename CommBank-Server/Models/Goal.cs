using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace CommBank.Models
{
    public class Goal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }

        public string? Icon { get; set; }

        public double TargetAmount { get; set; } = 0;

        public double Balance { get; set; } = 0.00;

        public DateTime Created { get; set; } = DateTime.Now;

        [BsonRepresentation(BsonType.ObjectId)]
        public List<string>? TransactionIds { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public List<string>? TagIds { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string? UserId { get; set; }
    }
}
