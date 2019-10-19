using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kookweb.DataAccess.EF.Context;
using Kookweb.DataAccess.Repository.Interface;
using Kookweb.DataAccess.Repository.Model;

namespace Kookweb.DataAccess.EF.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly AppDbContext _dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> condition = null)
        {
            return _dbContext.Set<T>();
        }

        public QueryResult<T> PagedList(int PageSize, int PageNumber, Expression<Func<T, bool>> condition = null)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}