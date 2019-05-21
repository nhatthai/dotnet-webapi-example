namespace WebApiSample.Models
{
    using WebApiSample;
    using MongoDB.Driver;

    public class TodoContext: ITodoContext
    {
        private readonly IMongoDatabase _db;
        public TodoContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }
        public IMongoCollection<Todo> Todos => _db.GetCollection<Todo>("Todos");
    }
}
