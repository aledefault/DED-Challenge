using MongoDB.Driver;

namespace DED.DevicesBus.Services
{
    public class MongoDbService
    {
        private static readonly MongoClient Client = new("mongodb://mongo:27017");
        public IMongoClient GetClient() => Client;
        public IMongoDatabase GetDatabase() => Client.GetDatabase("ded");
        public IMongoCollection<T> GetCollection<T>() => GetDatabase().GetCollection<T>(typeof(T).Name);
    }
}
