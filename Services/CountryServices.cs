using MongoDb.Data;
using MongoDb.Models;
using MongoDB.Driver;
namespace MongoDb.Services
{
    public class CountryServices
    {
        private readonly MongoDbContext _context;

        public CountryServices(MongoDbContext context)
        {
            _context = context;
        }

        public List<Country> GetAllCountry()
        {
            var deneme = _context.Countries.Find(_ => true).ToList();
            return deneme.ToList();
        }
    }
}
