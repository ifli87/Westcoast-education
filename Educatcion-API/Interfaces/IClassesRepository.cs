
using Educatcion_API.Models;
using Educatcion_API.ViewModels;

namespace Educatcion_API.Interfaces
{
    public interface IClassesRepository
    {
    public Task <List<ClassesViewModel>> ListAllClassesAsync ();
    // public Task <List<ClassesViewModel>> GetClassesByCategoryAsync(string category);
    public Task <ClassesViewModel?> GetClassesAsync(int id);  
    public Task AddClassesAsync (PostClassesViewModel model);
    public Task UppdateClassesAsync (int id, PutClassesViewModel model);
    public Task<bool> SaveAllAsync();

    }
}