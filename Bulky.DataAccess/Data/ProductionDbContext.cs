using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAcess.Data
{
    public class ProductionDbContext : DbContext
    {
        public ProductionDbContext(DbContextOptions<ProductionDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

    }
}
