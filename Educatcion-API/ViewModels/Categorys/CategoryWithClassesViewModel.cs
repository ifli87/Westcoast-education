namespace Educatcion_API.ViewModels.Categorys
{
    public class CategoryWithClassesViewModel
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<ClassesViewModel> Classes { get; set; } = new List<ClassesViewModel>();
    }
}