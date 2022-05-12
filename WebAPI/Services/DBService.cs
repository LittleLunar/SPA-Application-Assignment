using spa_backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace spa_backend.Services
{
    public class DBService
    {
        public IMongoCollection<User> UserCollection { get; private set; }

        public DBService(
          IOptions<DatabaseSettings> databaseSettings
        )
        {
            var mongoClient = new MongoClient(
              databaseSettings.Value.ConnectionString
            );

            Console.WriteLine("Connected To MongoDB");

            var mongoDatabase = mongoClient.GetDatabase(
              databaseSettings.Value.DatabaseName
            );

            UserCollection = mongoDatabase.GetCollection<User>(
              databaseSettings.Value.UsersCollectionName
            );
        }
    }
}
