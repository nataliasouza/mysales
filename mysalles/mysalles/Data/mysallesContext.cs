﻿using Microsoft.EntityFrameworkCore;
using mysalles.Models;

namespace mysalles.Data
{
    public class MySallesContext : DbContext
    {
        public MySallesContext (DbContextOptions<MySallesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller {  get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
