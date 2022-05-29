using System.ComponentModel.DataAnnotations;

namespace Educatcion_API.ViewModels.Categorys
{
    public class CategoryViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }

    }
}