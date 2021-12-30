using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductUseCase.Interfaces;

namespace UseCases.ProductUseCase
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository ProductRepository;
        public DeleteProductUseCase(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        public void Execute(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
        }
    }
}
