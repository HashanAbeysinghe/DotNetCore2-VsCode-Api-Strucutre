using ALMaster.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ALMaster.Domain
{
    public interface IRepository<TEntity>  where TEntity : IAggregateRoot
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        Task<TEntity> FindAsync(params object[] keyValues);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> FindAsync(IEnumerable<Guid> ids);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, int skip, int limit);

        Task<int> CountAsync<T>(Expression<Func<TEntity, bool>> predicate);
    }
}
