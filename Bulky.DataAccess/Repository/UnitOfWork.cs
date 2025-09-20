using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAccess.Data;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IRepository<Category> Categories { get;  private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Company> Companies{ get; private set; }
        public IRepository<ShoppingCart> ShoppingCarts { get; private set; }
        public IRepository<ApplicationUser> ApplicationUsers { get; private set; }
        public IRepository<OrderHeader> OrderHeaders { get; private set; }
        public IRepository<OrderDetail> OrderDetails { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Categories = new Repository<Category>(_db);
            Products = new Repository<Product>(_db);
            Companies = new Repository<Company>(_db);
            ShoppingCarts = new Repository<ShoppingCart>(_db);
            ApplicationUsers = new Repository<ApplicationUser>(_db);
            OrderHeaders = new Repository<OrderHeader>(_db);
            OrderDetails = new Repository<OrderDetail>(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
