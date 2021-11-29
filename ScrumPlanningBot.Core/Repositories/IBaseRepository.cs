using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ScrumPlanningBot.Core.Entities;

namespace ScrumPlanningBot.Core.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> Get();
        Task<T> GetById(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        Task Update(T item);
        Task Insert(T item);

    }
}