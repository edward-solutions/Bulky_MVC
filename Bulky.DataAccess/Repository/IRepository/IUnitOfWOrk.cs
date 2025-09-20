using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }
        IRepository<Product> Products { get; }
        IRepository<Company> Companies{ get; }
        IRepository<ShoppingCart> ShoppingCarts { get; }
        IRepository<ApplicationUser> ApplicationUsers { get; }
        IRepository<OrderHeader> OrderHeaders { get; }
        IRepository<OrderDetail> OrderDetails { get; }
        void Save();
    }
}
