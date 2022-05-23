using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educatcion_API.ViewModels.Categorys
{
    public class CategoryWithClassesViewModel
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public List<PostClassesViewModel> Classes { get; set; } = new List<PostClassesViewModel>();
    }
}