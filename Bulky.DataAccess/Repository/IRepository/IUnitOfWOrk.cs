using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWOrk
    {
        IRepository<Category> Categories { get; }
        IRepository<Product> Products { get; }
        void Save();
    }
}
