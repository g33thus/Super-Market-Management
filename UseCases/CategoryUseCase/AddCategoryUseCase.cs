using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.CategoryUseCase.Interfaces;

namespace UseCases.CategoryUseCase
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public AddCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            categoryRepository.AddCategory(category);
        }
    }
}
