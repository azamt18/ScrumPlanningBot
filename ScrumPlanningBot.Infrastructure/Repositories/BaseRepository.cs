using ScrumPlanningBot.Core.Entities;
using ScrumPlanningBot.Core.Repositories;

namespace ScrumPlanningBot.Infrastructure.Repositories
{
    public class BaseRepository<T>
    {
        //private IMongoDbContext _context;
        //private DbSet<T> _dbSet;

        //public BaseRepository(IMongoDbContext context)
        //{
        //    _context = context;
        //    _dbSet = context.Set<T>();
        //}

        //public IQueryable<T> Get()
        //{
        //    return _dbSet.AsNoTracking();
        //}

        //public async Task<T> GetById(int id)
        //{
        //    return await _dbSet.FindAsync(id);
        //}

        //public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        //{
        //    return _dbSet.Where(expression).AsNoTracking();
        //}

        //public Task Update(T item)
        //{
        //    _context.Entry(item).State = EntityState.Modified;
        //    return _context.SaveChangesAsync();
        //}

        //public async Task Insert(T item)
        //{
        //    await _dbSet.AddAsync(item);
        //    await _context.SaveChangesAsync();
        //}
    }
}