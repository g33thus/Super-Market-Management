using CoreBussiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.CategoryUseCase.Interfaces;

namespace UseCases.CategoryUseCase
{
    public class ViewCategoryUseCase : IViewCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategory();

        }
    }
}
