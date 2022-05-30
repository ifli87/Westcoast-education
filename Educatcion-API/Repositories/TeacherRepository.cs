using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.Data;
using Educatcion_API.Interfaces;
using Educatcion_API.ViewModels.Teacher;

namespace Educatcion_API.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ClassesContext _context;
        public TeacherRepository(ClassesContext context)
        {
            _context = context;
        }

        public Task AddTeacherAsync(PostTeacherViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherViewModel?> GetTeacherById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TeacherViewModel>> ListAllTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UppdateTeacherAsync(int id, PutTeacherViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}