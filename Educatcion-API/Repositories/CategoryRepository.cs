using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels;
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

        public async Task<CategoryViewModel?> GetCategoryById(int id)
        {
            return await _context.Categorys.Where(c => c.Id == id)
            .Select(categorys => new CategoryViewModel{
                Id = categorys.Id,
                CategoryName = categorys.CategoryName
            }).SingleOrDefaultAsync();
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

        public async Task<List<CategoryWithClassesViewModel>> ListCategorysClasses()
        {
           return await _context.Categorys.Include(c => c.Classes)
          .Select(m => new CategoryWithClassesViewModel{
              CategoryId = m.Id,
              CategoryName = m.CategoryName,
              Classes = m.Classes.Select(v => new ClassesViewModel{
                  Id = v.Id,
                  CourseNumber = v.CourseNumber,
                  Title = v.Title,
                  Length = v.Length,
                  Description = v.Description,
                  Details = v.Details
              }).ToList()
          }).ToListAsync();
        }

        public async Task<CategoryWithClassesViewModel?> ListCategorysClasses(int id)
        {
          return await _context.Categorys.Where(c=>c.Id == id).Include(c => c.Classes)
          .Select(m => new CategoryWithClassesViewModel{
              CategoryId = m.Id,
              CategoryName = m.CategoryName,
              Classes = m.Classes.Select(v => new ClassesViewModel{
                  Id = v.Id,
                  CourseNumber = v.CourseNumber,
                  Title = v.Title,
                  Length = v.Length,
                  Description = v.Description,
                  Details = v.Details
              }).ToList()
          }).SingleOrDefaultAsync();
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