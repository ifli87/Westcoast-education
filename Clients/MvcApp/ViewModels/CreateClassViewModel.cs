using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.ViewModels
{
    public class CreateClassViewModel
    {
         public int CourseNumber { get; set; }
        public string? Title { get; set; }
        public string? Length { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }
    }
}