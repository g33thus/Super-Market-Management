using CoreBussiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.CategoryUseCase.Interfaces;

namespace UseCases.CategoryUseCase
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(int CategoryId)
        {
            categoryRepository.DeleteCategory(CategoryId);
        }
    }
}
