using System.Collections.Generic;
using System.Linq;

namespace MVCWebApplication.Models
{
    public class ProductContext : IContext<Product>
    {
        public Product GetById(int id)
        {
            var products = GetAll();
            // retrieve a single "product" by id
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetByCategory(string category)
        {
            var products = GetAll();
            // retrieve products by category
            return products.Where(p => p.Category == category).ToList();
        }

        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product() { Id = 1, Name = "Toy Car", Description = "A fast car", Category = "Toy", Price = 9.99m },
                new Product() { Id = 2, Name = "Dolly Crys-A-Lot", Description = "A doll that crys", Category = "Toy", Price = 19.99m },
                new Product() { Id = 3, Name = "Pentium Computer", Description = "A superfast computer", Category = "Electronics", Price = 199.99m }
            };
        }
    }
}
