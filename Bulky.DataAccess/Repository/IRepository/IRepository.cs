using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //if "T" is Category table
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracker = false); //this is how we filter by LINQ to an entity
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entityList); //for deleting multiple records at once
    }
}
