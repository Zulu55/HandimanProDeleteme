using HandimanProDeleteme.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandimanProDeleteme.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
