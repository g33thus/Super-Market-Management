using CoreBussiness;

namespace UseCases.ProductUseCase.Interfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int id);
    }
}