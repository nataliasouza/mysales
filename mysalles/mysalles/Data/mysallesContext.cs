using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mysalles.Models;

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
