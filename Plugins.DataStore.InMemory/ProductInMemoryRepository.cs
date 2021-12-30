using CoreBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product() { Id=1,Name = "Beef", Quantity = 20, CategoryId =1, Price = 120},
                new Product() { Id=1,Name = "Chicken", Quantity = 24, CategoryId =1, Price = 320.50},
                 new Product() { Id=1,Name = "Lamb", Quantity = 10, CategoryId =1, Price = 220.445},
                  new Product() { Id=1,Name = "White Rice", Quantity = 110, CategoryId =5, Price = 20.25},
                   new Product() { Id=1,Name = "Red Rice", Quantity = 40, CategoryId =5, Price = 10.90},
                    new Product() { Id=1,Name = "Whole Grain Rice", Quantity = 50, CategoryId =5, Price = 160.99},
            };

        }

        public void AddProduct(Product Product)
        {
            if (products.Any(x => x.Name.Equals(Product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                Product.Id = products.Max(x => x.Id) + 1;
            }
            else { Product.Id = 1; }
            products.Add(Product);
        }

        public void UpdateProduct(Product Product)
        {
            var ProductToUpdate = products?.FirstOrDefault(x => x.Id == Product.Id);
            if (ProductToUpdate != null)
            {
                ProductToUpdate.Name = Product.Name;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products?.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteProduct(int ProductId)
        {
            products?.Remove(GetProduct(ProductId));
        }
    }
}
