using DrYoReparo.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrYoReparo.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<OrderService> OrdersServices { get; set; }
    }
}
