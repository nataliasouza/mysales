using Microsoft.EntityFrameworkCore;

namespace mysalles.Data
{
    public class mysallesContext : DbContext
    {
        public mysallesContext (DbContextOptions<mysallesContext> options)
            : base(options)
        {
        }

        public DbSet<mysalles.Models.Department> Department { get; set; }
    }
}
