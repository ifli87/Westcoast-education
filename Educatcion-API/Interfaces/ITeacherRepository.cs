using Educatcion_API.ViewModels.Teacher;

namespace Educatcion_API.Interfaces
{
    public interface ITeacherRepository
    {
        public Task <List<TeacherViewModel>> ListAllTeachersAsync();
        public Task <TeacherViewModel?> GetTeacherById(int id);
        public Task AddTeacherAsync (PostTeacherViewModel model);
        public Task UppdateTeacherAsync (int id, PutTeacherViewModel model);
        public Task<bool> SaveAllAsync();
    }
}