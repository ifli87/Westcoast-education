namespace Educatcion_API.ViewModels.Categorys
{
    public class CategoryWithClassesViewModel
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<PostClassesViewModel> Classes { get; set; } = new List<PostClassesViewModel>();
    }
}