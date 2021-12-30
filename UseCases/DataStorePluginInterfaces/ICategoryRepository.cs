using CoreBussiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategory();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategory(int id);
        void DeleteCategory(int categoryId);
    }
}
