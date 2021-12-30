using CoreBussiness;

namespace UseCases.CategoryUseCase.Interfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int id);
    }
}