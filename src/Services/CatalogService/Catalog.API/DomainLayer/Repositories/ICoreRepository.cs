using Catalog.API.DomainLayer.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Catalog.API.DomainLayer.Repositories
{
    public interface ICoreRepository<T> where T : CoreItem<T>
    {
        Task<List<T>> GetAll();
        Task<List<T>> Get(Expression<Func<T, bool>> predicate);
        Task<T> GetById(int id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> selector,
                                                     Expression<Func<T, bool>> predicate = null,
                                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                     Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                     bool disableTracking = true,
                                                     int pageIndex = 1, int pageSize = 3);

        Task<TResult> GetFilteredFirstorDefault<TResult>(Expression<Func<T, TResult>> selector,
                                                         Expression<Func<T, bool>> predicate = null,
                                                         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                         bool disableTracking = true);
        Task<bool> Any(Expression<Func<T, bool>> predicate);
    }
}
