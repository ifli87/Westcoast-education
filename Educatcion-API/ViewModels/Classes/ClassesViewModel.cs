namespace Educatcion_API.ViewModels
{
    public class ClassesViewModel
    {
        
        public int Id { get; set; }
        public int CourseNumber { get; set; }
        public string? Title { get; set; }
        public string? Length { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }
    }
}