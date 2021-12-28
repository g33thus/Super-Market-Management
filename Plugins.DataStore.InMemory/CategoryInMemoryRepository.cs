using CoreBussiness;
using System;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category() { CategoryId=1,Name = "Meat", Description="Meat"},
                 new Category() { CategoryId=2,Name = "Egg", Description="Egg"},
                  new Category() { CategoryId=3,Name = "Milk", Description="Milk"},
                new Category() { CategoryId=4,Name = "Fish", Description="Fish"},
                 new Category() { CategoryId=5,Name = "Rice", Description="Rice"}
            };

        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
