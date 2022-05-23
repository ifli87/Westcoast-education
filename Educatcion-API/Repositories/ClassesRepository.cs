using Educatcion_API.Data;
using Educatcion_API.Interfaces;
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
           var course = await _context.Categorys.Include(c => c.Classes).Where(c=>c.CategoryName!.ToLower() == model.Category!.ToLower()).SingleOrDefaultAsync();
           if (course is null)
           {
               throw new Exception($"Vi har tyvär inte denna kurs {model.Category} i systemet");
           }
        }

        public Task<List<ClassesViewModel>> GetClassesByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }

        public Task<ClassesViewModel?> GetClassesByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassesViewModel>> ListAllClassesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UppdateClassesAsync(int id, PostClassesViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
