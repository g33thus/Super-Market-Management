using CoreBussiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product Product);
        void UpdateProduct(Product Product);
        Product GetProduct(int id);
        void DeleteProduct(int ProductId);
    }
}
