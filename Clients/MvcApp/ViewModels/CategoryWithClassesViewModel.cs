using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.ViewModels
{
    public class CategoryWithClassesViewModel
    {
        public int Id { get; set; }
       
        public string? CategoryName { get; set; }

        public List<ClassesViewModel> Classes  { get; set; } =new List<ClassesViewModel>();

    }
}