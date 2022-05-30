using System.ComponentModel.DataAnnotations.Schema;

namespace Educatcion_API.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public int CourseNumber { get; set; }
        public string? Title { get; set; }
        public string? Length { get; set; }
        public int CategoryNameId { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey("CategoryId")]
         public Category Category { get; set; } = new Category();
         
         [ForeignKey("StudentId")]
         public ICollection<Student> Student { get; set; } = new List<Student>();

         [ForeignKey("TeacherId")]
          public ICollection<Teacher> Teacher { get; set; } = new List<Teacher>();

    }
}

