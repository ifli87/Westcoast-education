using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            await _context.Students.AddAsync(newStudent);
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
        public Task<StudentViewModel?> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> SaveAllAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public Task UppdateStudentAsync(int id, PutStudentViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}