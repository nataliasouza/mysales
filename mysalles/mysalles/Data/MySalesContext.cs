using Microsoft.EntityFrameworkCore;
using mySales.Models;

namespace mySales.Data
{
    public class MySalesContext : DbContext
    {
        public MySalesContext (DbContextOptions<MySalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller {  get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
