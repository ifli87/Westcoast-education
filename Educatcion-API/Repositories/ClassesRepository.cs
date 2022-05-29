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
           var categoryCourse = await _context.Categorys.Include
           (c => c.Classes).Where
           (c => c.CategoryName!
           .ToLower() == model.CategoryName!.ToLower()).SingleOrDefaultAsync();
            
            
            if (categoryCourse is null)
            {
              await _context.Categorys.AddAsync(categoryCourse!); // om categoryn inte finns skapar vi den

            }
        
           var classToAdd = new Classes
            {
                CourseNumber = model.CourseNumber, 
                Title = model.Title,
                Length = model.Length,
                // Category = model.CategoryName,
                Details = model.Details,
                Description = model.Description
            };
            classToAdd.Category = categoryCourse!; // rätt att ange att den inte är null?
            await _context.Classes.AddAsync(classToAdd);
        }

        public async Task<List<ClassesViewModel>> GetClassesByCategoryAsync(string category)
        {

               //   return await _context.Classes.Where(c => c.Category == category)
        //  .Select(classes => new ClassesViewModel
        //  {
        //      Id = classes.Id,
        //      CourseNumber = classes.CourseNumber,
        //      Title = classes.Title,
        //      Length = classes.Length,
        //      Description = classes.Description,
        //      Details = classes.Details
        //  }).SingleOrDefaultAsync();
            throw new NotImplementedException();
        }

        public async Task<ClassesViewModel?> GetClassesAsync(int id)
        {
         return await _context.Classes.Where(c => c.Id == id)
         .Select(classes => new ClassesViewModel
         {
             Id = classes.Id,
             CourseNumber = classes.CourseNumber,
             Title = classes.Title,
             Length = classes.Length,
             Description = classes.Description,
             Details = classes.Details
         }).SingleOrDefaultAsync();
        }

        public async Task <List<ClassesViewModel>> ListAllClassesAsync()
        {
           var response = await _context.Classes.ToListAsync();
           var classesList = new List<ClassesViewModel>();
           foreach (var Class in response) 
           {
               classesList.Add(
                   new ClassesViewModel
                   {    
                       Id = Class.Id,
                       CourseNumber = Class.CourseNumber,
                       Title = Class.Title,
                       Length = Class.Length,
                       Description = Class.Description,
                       Details = Class.Details
                   });
                }
                   return (classesList);   
        }

        public async Task<bool> SaveAllAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public async Task UppdateClassesAsync(int id, PutClassesViewModel model)
        {
            var classes = await _context.Classes.FindAsync(id);
            if (classes is null)
            {
                throw new Exception($"Vi kunde inte hitta någon kurs med detta id{id}");
            }

            classes.Title = model.Title;
            classes.Length = model.Length;
            classes.Description = model.Details;
            classes.Details = model.Details;

            _context.Classes.Update(classes);
            
        }
        }
}
