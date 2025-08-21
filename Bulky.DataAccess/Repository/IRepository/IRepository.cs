using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    internal interface IRepository<T> where T : class
    {
        //if "T" is Category table
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter); //this is how we filter by LINQ to an entity
        void Add(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entityList); //for deleting multiple records at once
    }
}
