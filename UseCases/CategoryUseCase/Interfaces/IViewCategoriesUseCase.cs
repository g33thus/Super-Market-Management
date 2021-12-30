using CoreBussiness;
using System.Collections.Generic;

namespace UseCases.CategoryUseCase.Interfaces
{
    public interface IViewCategoryUseCase
    {
        IEnumerable<Category> Execute();
    }
}
