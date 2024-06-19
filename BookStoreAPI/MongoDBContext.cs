using BookStoreAPI.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Runtime;

namespace BookStoreAPI
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;
        private readonly MongoDBSettings _settings;


        public MongoDBContext(IOptions<MongoDBSettings> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            _database = client.GetDatabase(_settings.DatabaseName);

        }

        public IMongoCollection<Book> Books => _database.GetCollection<Book>(_settings.BookCollectionName);
        public IMongoCollection<User> Users => _database.GetCollection<User>(_settings.UserCollectionName);
    }
}
