using MongoDB.Driver;
using ScrumPlanningBot.Core.Entities;

namespace ScrumPlanningBot.Infrastructure.DBContexts
{
    public interface IMongoDbContext<T> where T : BaseEntity
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}