using System.Collections.Generic;
using System.Linq;
using HomeWork_Day34.Pages.Admin;

namespace BlazorProductManagement.Data
{
    public class ProductService
    {
        private List<Product> products = new()
        {
            new Product { Id = 1, Name = "Nike Air Max", Alias = "air-max", Price = 350, Description = "Best running shoes", ImageUrl = "/images/nike_air_max.jpg" },
            new Product { Id = 2, Name = "Vans Old Skool", Alias = "vans-old-skool", Price = 250, Description = "Classic skate shoes", ImageUrl = "/images/vans_old_skool.jpg" }
        };

        public List<Product> GetProducts() => products;

        public Product GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }

        public void DeleteProduct(int id) => products.RemoveAll(p => p.Id == id);

        public void UpdateProduct(Product product)
        {
            var existing = products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Alias = product.Alias;
                existing.Price = product.Price;
                existing.Description = product.Description;
                existing.ImageUrl = product.ImageUrl;
            }
        }
    }
}
