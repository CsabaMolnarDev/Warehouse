using Microsoft.EntityFrameworkCore;
using Warehouse.Data.Entities;

namespace Warehouse.Data
{
    // This class is the gateway to the database.
    public class AppDbContext : DbContext
    {
    
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Register your tables here (just like registering models)
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //Dummy data for database
        // use: Add-Migration SeedInitialData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Office Supplies" },
                new Category { Id = 3, Name = "Clothing" }
            );

            // 2. Seed Products linked to those categories with CategoryId
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Mechanical Keyboard",
                    SKU = "SS-KEY-MECH-01",
                    Price = 69.99m,
                    Quantity = 30,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Ergonomic Desk Chair",
                    SKU = "OFC-CHR-ERGO-05",
                    Price = 149.50m,
                    Quantity = 15,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Cotton Crewneck Nike T-Shirt",
                    SKU = "NIK-TSH-WHT-MED",
                    Price = 13.99m,
                    Quantity = 157,
                    CategoryId = 3
                }
            );
        }
    }
}
