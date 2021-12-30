using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.CategoryUseCase.Interfaces;

namespace UseCases.CategoryUseCase
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Execute(int id)
        {
            return categoryRepository.GetCategory(id);
        }
    }
}
