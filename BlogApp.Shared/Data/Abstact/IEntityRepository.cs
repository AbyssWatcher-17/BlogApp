using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstact
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        Task<T> GetAsync(Expression<Func<T, object>>[] includeProperties, Expression<Func<T,bool>> predicate);

        Task<IList<T>> GetAllAsync(Expression<Func<T, object>>[] includeProperties, Expression<Func<T, bool>> predicate=null);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}
