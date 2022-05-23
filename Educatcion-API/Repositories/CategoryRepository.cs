using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.ViewModels.Categorys;

namespace Educatcion_API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ClassesContext _context;
        public CategoryRepository(ClassesContext context)
        {
            _context = context;
        }

        public Task AddCategoryAsync(PostCategoryViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryViewModel> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryViewModel>> ListCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryWithClassesViewModel>> ListCategorysClasses()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryWithClassesViewModel?> ListCategorysClasses(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(int id, PutCategoryViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}