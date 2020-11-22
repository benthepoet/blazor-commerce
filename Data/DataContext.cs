using Microsoft.EntityFrameworkCore;

namespace BlazorCommerce.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) {}

        public DbSet<Models.Cart> Cart { get; set; }
        public DbSet<Models.CartLine> CartLine { get; set; }
        public DbSet<Models.Category> Category { get; set; }
        public DbSet<Models.Order> Order { get; set; }
        public DbSet<Models.Product> Product { get; set; }
        public DbSet<Models.ProductVariant> ProductVariant { get; set; }
    }
}