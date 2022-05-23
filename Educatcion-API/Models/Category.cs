namespace Educatcion_API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        public ICollection<Classes> Classes { get; set; } = new List<Classes>();
    }
}