using System.Collections.Generic;

namespace Kookweb.DataAccess.Repository.Model
{
    public class QueryResult<T> where T : class
    {
        public int TotalCount { get; set; }
        public IEnumerable<T> Result { get; set; }
    }
}