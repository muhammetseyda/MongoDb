using MongoDb.Models;
using MongoDB.Driver;

namespace MongoDb.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("MSA");
        }

        public IMongoCollection<Country> Countries => _database.GetCollection<Country>("Countries");
    }
}
