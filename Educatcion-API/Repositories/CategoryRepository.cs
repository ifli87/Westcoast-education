using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels.Categorys;
using Microsoft.EntityFrameworkCore;

namespace Educatcion_API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ClassesContext _context;
        public CategoryRepository(ClassesContext context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(PostCategoryViewModel model)
        {
        
           var category = new Category
           {
               CategoryName = model.CategoryName
           };
          await _context.Categorys.AddAsync(category);
     
        }

        public Task<CategoryViewModel> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task <List<CategoryViewModel>> ListCategoryAsync()
        {
           var response = await _context.Categorys.ToListAsync();
           var categoryList = new List<CategoryViewModel>();
           foreach (var Category in response)
           {
           categoryList.Add(
                new CategoryViewModel
                {
               Id = Category.Id,
               CategoryName = Category.CategoryName 
           });
           }
           return(categoryList);
        }

        public Task<List<CategoryWithClassesViewModel>> ListCategorysClasses()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryWithClassesViewModel?> ListCategorysClasses(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
             return await _context.SaveChangesAsync() > 0;
        }

        public Task UpdateCategory(int id, PutCategoryViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}