using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels.Student;
using Microsoft.EntityFrameworkCore;

namespace Educatcion_API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ClassesContext _context;
        public StudentRepository(ClassesContext context)
        {
            _context = context;
        }

        public async Task AddStudentAsync(PostStudentViewModel model)
        {
            var newStudent = new Student 
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Telephone = model.Telephone,
                Adress = model.Adress,
                City = model.City,
                ZipCode = model.ZipCode  
            };
            await _context.AddAsync(newStudent);
          
        }

       

        public async Task<List<StudentViewModel>> ListAllStudentsAsync()
        {
         var response = await _context.Students.ToListAsync();
         var studetList = new List<StudentViewModel>();
         foreach (var Student in response)
         {
             studetList.Add(
                 new StudentViewModel {
                    Id = Student.Id,
                    FirstName = Student.FirstName,
                    LastName = Student.LastName,
                    Email = Student.Email,
                    Telephone = Student.Telephone,
                    Adress = Student.Adress,
                    City = Student.City,
                    ZipCode = Student.ZipCode
                 });
         }
                 return (studetList);
        }

        public async Task UppdateStudentAsync(int id, PutStudentViewModel model)
        {
           var student = await _context.Students.FindAsync(id);
            if (student is null)
            {
                throw new Exception($"Vi kunde inte hitta någon student med detta id{id}");
            }

            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Email = model.Email;
            student.Telephone = model.Telephone;
            student.Adress = model.Adress;
            student.City = model.City;
            student.ZipCode = model.ZipCode;

            _context.Students.Update(student);
            
        }
        public async Task<StudentViewModel?> GetStudentById(int id)
        {
           return await _context.Students.Where(c => c.Id == id)
         .Select(student => new StudentViewModel
         {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Email = student.Email,
            Telephone = student.Telephone,
            Adress = student.Adress,
            City = student.City,
            ZipCode = student.ZipCode
         }).SingleOrDefaultAsync();
        }
        

        public async Task<bool> SaveAllAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

    }
}
