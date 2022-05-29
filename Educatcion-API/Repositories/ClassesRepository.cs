using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Educatcion_API.Repositories
{
    public class ClassesRepository : IClassesRepository
    {
        private readonly ClassesContext _context;
        public ClassesRepository(ClassesContext context)
        {
            _context = context;
        }

        public async Task AddClassesAsync(PostClassesViewModel model)
        {
        //    var categoryCourse = await _context.Categorys.Include(c => c.Classes).Where(c => c.CategoryName!.ToLower() == model.Category!.ToLower()).SingleOrDefaultAsync();
           
        //    if (categoryCourse is null)
        //    {
        //        throw new Exception($"Vi har tyvär inte denna kurs {model.Category} i systemet");
        //    }
           var classToAdd = new Classes
            {
                CourseNumber = model.CourseNumber, 
                Title = model.Title,
                Length = model.Length,
                Details = model.Details,
                Description = model.Description
            };
            // classToAdd.Category = categoryCourse;
            await _context.Classes.AddAsync(classToAdd);
        }

        public async Task<List<ClassesViewModel>> GetClassesByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }

        public Task<ClassesViewModel?> GetClassesByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task <List<ClassesViewModel>> ListAllClassesAsync()
        {
            var response = await _context.Classes.ToListAsync();
           var classesList = new List<ClassesViewModel>();
           foreach (var classes in response) // class
           {
               classesList.Add(
                   new ClassesViewModel
                   {
                       CourseNumber = classes.CourseNumber,
                       Title = classes.Title,
                       Length = classes.Length,
                       Description = classes.Description,
                       Details = classes.Details
                   });
                }
                   return (classesList);   
        }

        public async Task<bool> SaveAllAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public Task UppdateClassesAsync(int id, PostClassesViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
