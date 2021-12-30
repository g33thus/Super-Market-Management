using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductUseCase.Interfaces;

namespace UseCases.ProductUseCase
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository ProductRepository;
        public AddProductUseCase(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        public void Execute(Product Product)
        {
            ProductRepository.AddProduct(Product);
        }
    }
}
