using MongoDB.Bson.Serialization.Attributes;

namespace test_with_mongo.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        public string? Name { get; set; } = null;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
