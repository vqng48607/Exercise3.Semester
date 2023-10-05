using Microsoft.EntityFrameworkCore;

namespace MyFirstAPI.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category for 1" },
                new Category { Id = 2, Name = "Category for 2" },
                new Category { Id = 3, Name = "Category for 3" },
                new Category { Id = 4, Name = "Category for 4" },
                new Category { Id = 5, Name = "Category for 5" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Product 1" },
                new Product { Id = 2, CategoryId = 1, Name = "Product 2" },
                new Product { Id = 3, CategoryId = 1, Name = "Product 3" },
                new Product { Id = 4, CategoryId = 1, Name = "Product 4" },
                new Product { Id = 5, CategoryId = 1, Name = "Product 5" },
                new Product { Id = 6, CategoryId = 2, Name = "Product 6" },
                new Product { Id = 7, CategoryId = 2, Name = "Product 7" },
                new Product { Id = 8, CategoryId = 2, Name = "Product 8" },
                new Product { Id = 9, CategoryId = 2, Name = "Product 9" },
                new Product { Id = 10, CategoryId = 2, Name = "Product 10" },
                new Product { Id = 11, CategoryId = 2, Name = "Product 11" },
                new Product { Id = 12, CategoryId = 3, Name = "Product 12" },
                new Product { Id = 13, CategoryId = 3, Name = "Product 13" },
                new Product { Id = 14, CategoryId = 3, Name = "Product 14" },
                new Product { Id = 15, CategoryId = 3, Name = "Product 15" },
                new Product { Id = 16, CategoryId = 4, Name = "Product 16" },
                new Product { Id = 17, CategoryId = 4, Name = "Product 17" },
                new Product { Id = 18, CategoryId = 5, Name = "Product 18" },
                new Product { Id = 19, CategoryId = 5, Name = "Product 19" }
                );
        }
    }
}
