using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=product.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "FPS" },
                new Category { CategoryID = 2, CategoryName = "Favorites" },
                new Category { CategoryID = 3, CategoryName = "Dogshit" },
                new Category { CategoryID = 4, CategoryName = "Friends" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Call of Duty Black Ops I " },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Call of Duty Black Ops II " },
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Call of Duty Black Ops III " },
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Call of Duty Black Ops IV " },
                new Product { ProductID = 5, CategoryID = 1, ProductName = "Call of Duty Black Ops Cold War " },
                new Product { ProductID = 6, CategoryID = 1, ProductName = "Call of Duty Black Ops VI " },
                new Product { ProductID = 7, CategoryID = 1, ProductName = "Call of Duty Modern Warfare " },
                new Product { ProductID = 8, CategoryID = 1, ProductName = "Call of Duty Modern Warfare II " },
                new Product { ProductID = 9, CategoryID = 1, ProductName = "Call of Duty Modern Warfare III " },
                new Product { ProductID = 10, CategoryID = 1, ProductName = "Call of Duty Modern Warfare(2019) " },
                new Product { ProductID = 11, CategoryID = 1, ProductName = "Call of Duty Modern Warfare II(2022) " },
                new Product { ProductID = 12, CategoryID = 1, ProductName = "Call of Duty Modern Warfare III(2023) " },
                new Product { ProductID = 13, CategoryID = 1, ProductName = "Call of Duty Vanguard " },
                new Product { ProductID = 14, CategoryID = 1, ProductName = "Call of Duty I "},
                new Product { ProductID = 15, CategoryID = 1, ProductName = "Call of Duty United Offensive " },

                new Product { ProductID = 16, CategoryID = 2, ProductName = "Dead by Daylight " },
                new Product { ProductID = 17, CategoryID = 2, ProductName = "Genshin Impact" },
                new Product { ProductID = 18, CategoryID = 2, ProductName = "Red Dead Redemption 2 " },
                new Product { ProductID = 19, CategoryID = 2, ProductName = "Tom Clancy's Splinter Cell " },
                new Product { ProductID = 20, CategoryID = 2, ProductName = "Tom Clancy's Rainbow Six Siege " },
                new Product { ProductID = 21, CategoryID = 2, ProductName = "Assassin's Creed III " },
                new Product { ProductID = 22, CategoryID = 2, ProductName = "Far Cry 5 " },
                new Product { ProductID = 23, CategoryID = 2, ProductName = "Grand Theft Auto V " },
                new Product { ProductID = 24, CategoryID = 2, ProductName = "Grand Theft Auto San Andreas " },
                new Product { ProductID = 25, CategoryID = 2, ProductName = "Cities Skylines II " },
                new Product { ProductID = 26, CategoryID = 2, ProductName = "Victoria III " },
                new Product { ProductID = 27, CategoryID = 2, ProductName = "Overwatch " },

                new Product { ProductID = 28, CategoryID = 3, ProductName = "Valorant " },
                new Product { ProductID = 29, CategoryID = 3, ProductName = "Apex Legends " },
                new Product { ProductID = 30, CategoryID = 3, ProductName = "Starfield " },

                new Product { ProductID = 31, CategoryID = 4, ProductName = "Stadolisci " },
                new Product { ProductID = 32, CategoryID = 4, ProductName = "Crackrock " },
                new Product { ProductID = 33, CategoryID = 4, ProductName = "Tristan " },
                new Product { ProductID = 34, CategoryID = 4, ProductName = "Axalta88 " }
                );
        }
    }
}
