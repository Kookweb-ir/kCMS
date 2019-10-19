using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kookweb.DataAccess.Repository.Model;

namespace Kookweb.DataAccess.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(int Id);
        QueryResult<T> PagedList(int PageSize, int PageNumber, Expression<Func<T, bool>> condition = null);
        IEnumerable<T> List(Expression<Func<T, bool>> condition = null);
        T Insert(T entity);
        T Update(T entity);
        bool Delete(int Id);
        bool Delete(T entity);
    }
}