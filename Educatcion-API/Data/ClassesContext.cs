using Educatcion_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Educatcion_API.Data
{
    public class ClassesContext : DbContext
    {
        public DbSet<Classes> Classes =>Set<Classes>();
        public DbSet<Category> Categorys =>Set<Category>();
        public DbSet<Student> Students =>Set<Student>();
        public DbSet<Teacher> Teachers =>Set<Teacher>();
        public ClassesContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
