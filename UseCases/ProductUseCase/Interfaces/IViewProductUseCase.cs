using CoreBussiness;
using System.Collections.Generic;

namespace UseCases.ProductUseCase.Interfaces
{
    public interface IViewProductUseCase
    {
        IEnumerable<Product> Execute();
    }
}
