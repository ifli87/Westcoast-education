using System.ComponentModel.DataAnnotations;

namespace Educatcion_API.ViewModels
{
    public class PostClassesViewModel
    {
       [Required]
        public int CourseNumber { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Length { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Details { get; set; }
    }
}