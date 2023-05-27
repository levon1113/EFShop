using EFShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFShop.Data.Context
{
    public class EFShopDbContext:DbContext
    {
        private const string connectionString = "Data Source=localhost;" +
                "Initial Catalog=EFShopDB; Integrated Security=true;" +
                "TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
             optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Product>().HasMany<Shop>();
            modelBuilder.Entity<Shop>().HasOne<Product>();*/
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }

    }
}
