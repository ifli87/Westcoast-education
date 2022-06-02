using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.ViewModels.Categorys;

namespace Educatcion_API.Interfaces
{
    public interface ICategoryRepository 
    {
        public Task AddCategoryAsync (PostCategoryViewModel model);
        public Task <List<CategoryViewModel>> ListCategoryAsync();
        public Task <CategoryViewModel?> GetCategoryById(int id);
        public Task <List<CategoryWithClassesViewModel>> ListCategorysClasses();
        public Task <CategoryWithClassesViewModel?> ListCategorysClasses(int id);
        public Task UpdateCategory(int id, PutCategoryViewModel model);
         public Task<bool> SaveAllAsync();


    }
}