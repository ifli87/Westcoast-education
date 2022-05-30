using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.ViewModels.Student;

namespace Educatcion_API.Interfaces
{
    public interface IStudentRepository
    {
    public Task <List<StudentViewModel>> ListAllStudentsAsync();
    public Task <StudentViewModel?> GetStudentById (int id);
    public Task AddStudentAsync (PostStudentViewModel model);
    public Task UppdateStudentAsync (int id, PutStudentViewModel model);
    public Task<bool> SaveAllAsync();
    
    }
}