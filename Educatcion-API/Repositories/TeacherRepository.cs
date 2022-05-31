using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels.Teacher;
using Microsoft.EntityFrameworkCore;

namespace Educatcion_API.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ClassesContext _context;
        public TeacherRepository(ClassesContext context)
        {
            _context = context;
        }

        public async Task AddTeacherAsync(PostTeacherViewModel model)
        {
           var newTeacher = new Teacher 
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Telephone = model.Telephone,
                Adress = model.Adress,
                City = model.City,
                ZipCode = model.ZipCode  
            };
            await _context.Teachers.AddAsync(newTeacher);
        }

        public async Task<List<TeacherViewModel>> ListAllTeachersAsync()
        {
           var teacherResponse = await _context.Teachers.ToListAsync();
           var teacherList = new List<TeacherViewModel>();
           foreach (var Teacher in teacherResponse)
           {
               teacherList.Add(
                   new TeacherViewModel{
                   Id = Teacher.Id,
                   FirstName = Teacher.FirstName,
                    LastName = Teacher.LastName,
                    Email = Teacher.Email,
                    Telephone = Teacher.Telephone,
                    Adress = Teacher.Adress,
                    City = Teacher.City,
                    ZipCode = Teacher.ZipCode
               });
           }
           return (teacherList);
        }
        public Task<TeacherViewModel?> GetTeacherById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task <bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task UppdateTeacherAsync(int id, PutTeacherViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}