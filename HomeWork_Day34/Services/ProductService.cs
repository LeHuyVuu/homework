using System.Collections.Generic;
using System.Linq;
using HomeWork_Day34.Pages.Admin;

namespace BlazorProductManagement.Data
{
    public class ProductService
    {
        private List<Product> products = new()
        {
            new Product { Id = 1, Name = "Nike Air Max", Alias = "air-max", Price = 350, Description = "Best running shoes", ImageUrl = "https://th.bing.com/th/id/OIP.C0b3zlLfZ0GD-5txQXOkzQHaE8?rs=1&pid=ImgDetMain" },
            new Product { Id = 2, Name = "Vans Old Skool", Alias = "vans-old-skool", Price = 250, Description = "Classic skate shoes", ImageUrl = "https://vn-live-01.slatic.net/p/52470293e688d6eef62b7ed9074a41eb.jpg" }
        };

        public List<Product> GetProducts() => products;

        public Product GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

        public void AddProduct(Product product)
        {
            product.Id = products.Any() ? products.Max(p => p.Id) + 1 : 1;
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
