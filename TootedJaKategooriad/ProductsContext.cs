using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite
            ("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Dairy" },
                new Category { CategoryID = 2, CategoryName = "Candies" },
                new Category { CategoryID = 3, CategoryName = "Vegetables" },
                new Category { CategoryID = 4, CategoryName = "Drinks" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Milk" },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Cheese" },
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Cottage cheese" },
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Parmesan" },
                new Product { ProductID = 5, CategoryID = 1, ProductName = "Yoghurt" },
                new Product { ProductID = 6, CategoryID = 1, ProductName = "Chocolate milk" },
                new Product { ProductID = 7, CategoryID = 1, ProductName = "Whipped cream" },
                new Product { ProductID = 8, CategoryID = 1, ProductName = "Blue cheese" },
                new Product { ProductID = 9, CategoryID = 2, ProductName = "Chocolate" },
                new Product { ProductID = 10, CategoryID = 2, ProductName = "Gummy bear" },
                new Product { ProductID = 11, CategoryID = 2, ProductName = "Watermelon gum" },
                new Product { ProductID = 12, CategoryID = 2, ProductName = "Sour balls" },
                new Product { ProductID = 13, CategoryID = 2, ProductName = "Pistachio candy" },
                new Product { ProductID = 14, CategoryID = 2, ProductName = "Orange chews" },
                new Product { ProductID = 15, CategoryID = 2, ProductName = "Sour patch" },
                new Product { ProductID = 16, CategoryID = 2, ProductName = "Haribo" },
                new Product { ProductID = 17, CategoryID = 3, ProductName = "Carrot" },
                new Product { ProductID = 18, CategoryID = 3, ProductName = "Turnip" },
                new Product { ProductID = 19, CategoryID = 3, ProductName = "Radish" },
                new Product { ProductID = 20, CategoryID = 3, ProductName = "Cucumber" },
                new Product { ProductID = 21, CategoryID = 3, ProductName = "Tomato" },
                new Product { ProductID = 22, CategoryID = 3, ProductName = "Lettuce" },
                new Product { ProductID = 23, CategoryID = 3, ProductName = "Cabbage" },
                new Product { ProductID = 24, CategoryID = 3, ProductName = "Potato" },
                new Product { ProductID = 25, CategoryID = 4, ProductName = "Coffee" },
                new Product { ProductID = 26, CategoryID = 4, ProductName = "Tea" },
                new Product { ProductID = 27, CategoryID = 4, ProductName = "Coca cola" },
                new Product { ProductID = 28, CategoryID = 4, ProductName = "Fanta" },
                new Product { ProductID = 29, CategoryID = 4, ProductName = "Monster" },
                new Product { ProductID = 30, CategoryID = 4, ProductName = "Red Bull" },
                new Product { ProductID = 31, CategoryID = 4, ProductName = "Water" },
                new Product { ProductID = 32, CategoryID = 4, ProductName = "Pepsi" },
                new Product { ProductID = 33, CategoryID = 4, ProductName = "Limpa" }
                );
        }
    }
}
