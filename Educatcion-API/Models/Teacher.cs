using System.ComponentModel.DataAnnotations.Schema;

namespace Educatcion_API.Models
{
    public class Teacher
    {
        
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int Telephone { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }   
        public int ZipCode { get; set; }
        public int ClassesId { get; set; }
        public int ExperienceId { get; set; }

        [ForeignKey("ClassesId")]
        public ICollection<Classes> Classes { get; set; } = new List<Classes>();
        [ForeignKey("ExperienceId")]
        public ICollection<Category> Experience { get; set; } = new List<Category>();


    }

}
