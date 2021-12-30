using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductUseCase.Interfaces;

namespace UseCases.ProductUseCase
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepository ProductRepository;
        public GetProductByIdUseCase(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        public Product Execute(int id)
        {
            return ProductRepository.GetProduct(id);
        }
    }
}
