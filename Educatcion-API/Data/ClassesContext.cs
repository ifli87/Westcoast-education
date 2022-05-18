using Educatcion_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Educatcion_API.Data
{
    public class ClassesContext : DbContext
    {
         public DbSet<Classes> Vehicles =>Set<Classes>();
         
          public ClassesContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
