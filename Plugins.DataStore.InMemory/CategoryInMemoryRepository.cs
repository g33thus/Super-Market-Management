using CoreBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> Category;
        public CategoryInMemoryRepository()
        {
            Category = new List<Category>()
            {
                new Category() { Id=1,Name = "Meat", Description="Meat"},
                 new Category() { Id=2,Name = "Egg", Description="Egg"},
                  new Category() { Id=3,Name = "Milk", Description="Milk"},
                new Category() { Id=4,Name = "Fish", Description="Fish"},
                 new Category() { Id=5,Name = "Rice", Description="Rice"}
            };

        }

        public void AddCategory(Category category)
        {
            if (Category.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (Category != null && Category.Count > 0)
            {
                category.Id = Category.Max(x => x.Id) + 1;
            }
            else { category.Id = 1; }
            Category.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = Category?.FirstOrDefault(x => x.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetCategory()
        {
            return Category;
        }

        public Category GetCategory(int id)
        {
            return Category?.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteCategory(int categoryId)
        {
            Category?.Remove(GetCategory(categoryId));
        }
    }
}
