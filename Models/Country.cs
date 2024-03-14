using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDb.Models
{
    public class Country
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("capital")]
        public string Capital { get; set; }

        [BsonElement("population")]
        public long Population { get; set; }

        [BsonElement("area_sq_km")]
        public long AreaSqKm { get; set; }

        [BsonElement("currency")]
        public string Currency { get; set; }
    }
}
