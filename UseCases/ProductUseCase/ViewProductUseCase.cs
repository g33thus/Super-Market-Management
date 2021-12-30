using CoreBussiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductUseCase.Interfaces;

namespace UseCases.ProductUseCase
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        private readonly IProductRepository ProductRepository;

        public ViewProductUseCase(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }
        public IEnumerable<Product> Execute()
        {
            return ProductRepository.GetProducts();

        }
    }
}
