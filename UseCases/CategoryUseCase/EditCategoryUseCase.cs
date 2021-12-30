using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.CategoryUseCase.Interfaces;

namespace UseCases.CategoryUseCase
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public EditCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }
    }
}
