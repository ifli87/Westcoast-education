using System.ComponentModel.DataAnnotations.Schema;

namespace Educatcion_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int TeacherId { get; set; }
         [ForeignKey("TeacherId")]
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Classes> Classes { get; set; } = new List<Classes>();
    }
}