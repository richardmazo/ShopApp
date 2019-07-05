

namespace ShopAppWeb.Data
{

    using Microsoft.EntityFrameworkCore;
    using ShopAppWeb.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

    }
}
