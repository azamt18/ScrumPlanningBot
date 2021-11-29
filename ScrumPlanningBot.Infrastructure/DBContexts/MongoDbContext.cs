using MongoDB.Driver;

namespace ScrumPlanningBot.Infrastructure.DBContexts
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database = null;
        private MongoClient _mongoClient { get; set; }

        //public MongoDbContext(IOptions<MongoDbSettings> configuration)
        //{
        //    _mongoClient = new MongoClient(configuration.Value.ConnectionString);
        //    _database = _mongoClient.GetDatabase(configuration.Value.DatabaseName);
        //}
        
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // To remove the requests to the Migration History table
        //    Database.SetInitializer<MongoDBContext>(null);
        //    // To remove the plural names   
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

        //public TelegramContext(IOptions<MongoDbSettings> settings)
        //{
        //    var client = new MongoClient(settings.Value.ConnectionString);
        //    if (client != null)
        //        _database = client.GetDatabase(settings.Value.Database);
        //}

        //public DbSet<User> Users { get; set; }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}