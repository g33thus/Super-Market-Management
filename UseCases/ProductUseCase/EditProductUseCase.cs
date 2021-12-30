using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductUseCase.Interfaces;

namespace UseCases.ProductUseCase
{
    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly IProductRepository ProductRepository;
        public EditProductUseCase(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        public void Execute(Product Product)
        {
            ProductRepository.UpdateProduct(Product);
        }
    }
}
